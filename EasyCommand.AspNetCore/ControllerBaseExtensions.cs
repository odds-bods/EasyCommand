using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace EasyCommand.AspNetCore
{
    public static class ControllerBaseExtensions
    {
        private static IServiceScope Scope;

        public static void RegisterScope(IServiceScope scope)
        {
            Scope = scope;
        }

        public static async Task<TResult> ExecuteAsync<TRequest, TResult>(this ControllerBase that, IAsyncAspCommand<TRequest, TResult> command)
        {
            command.SetController(that);
            return await command.ExecuteCommandAsync(default(TRequest));
        }

        public static async Task<TResult> ExecuteAsync<TRequest, TResult>(this ControllerBase that, IAsyncAspCommand<TRequest, TResult> command, TRequest request)
        {
            command.SetController(that);
            return await command.ExecuteCommandAsync(request);
        }

        public static TCommand Command<TCommand>(this ControllerBase that)
            where TCommand : IAsyncCommand
        {
            return Scope.ServiceProvider.GetService<TCommand>();
        }
    }
}
