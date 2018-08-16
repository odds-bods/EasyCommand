using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace EasyCommand.AspNetCore
{
    public static class EasyCommandApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseEasyCommand(this IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();

            // TOOD: Might be a more elegant way to do this.
            ControllerBaseExtensions.RegisterScope(scope);

            return app;
        }
    }
}
