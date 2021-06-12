using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Common
{
    public abstract class BaseDeletableEntity<TKey> : BaseEntity<TKey>, IDeletableEntity
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string DeletedBy { get; set; }

        public void Delete(string userId)
        {
            DeletedBy = userId;
            DeletedOn = DateTime.Now;
            IsDeleted = true;
        }
    }
}
