using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace EasyCommand.AspNetCore
{
    public static class AsyncAspCommandExtensions
    {
        private static IServiceScope Scope;

        public static void RegisterScope(IServiceScope scope)
        {
            Scope = scope;
        }

        public static async Task<TInjectedResult> ExecuteAsync<TRequest, TResult, TInjectedRequest, TInjectedResult>
            (this IAsyncAspCommand<TRequest, TResult> command, IAsyncAspCommand<TInjectedRequest, TInjectedResult> injectedCommand)
        {
            return await injectedCommand.ExecuteExternalAsync(default(TInjectedRequest));
        }

        public static async Task<TInjectedResult> ExecuteAsync<TRequest, TResult, TInjectedRequest, TInjectedResult>
               (this IAsyncAspCommand<TRequest, TResult> command, IAsyncAspCommand<TInjectedRequest, TInjectedResult> injectedCommand, TInjectedRequest request)
        { 
            return await injectedCommand.ExecuteExternalAsync(request);
        }

        public static TCommand Command<TCommand>(this IAsyncCommand command) where TCommand : IAsyncCommand
        {
            return Scope.ServiceProvider.GetService<TCommand>();
        }

    }
}
