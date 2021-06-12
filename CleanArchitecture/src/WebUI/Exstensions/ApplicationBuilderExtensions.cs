using Microsoft.AspNetCore.Builder;

namespace CleanArchitecture.WebUI.Exstensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseEndpointsWithAreas(this IApplicationBuilder app)
            => app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
    }
}
