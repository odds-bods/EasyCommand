using System.Threading.Tasks;

namespace EasyCommand.AspNetCore
{
    public static class IAsyncAspCommandExtensions
    {
        public static async Task<TResult> ExecuteAsync<TRequest, TResult>(this IAsyncAspCommand<TRequest, TResult> command, IAsyncAspCommand<TRequest, TResult> injectedCommand)
        {
            return await injectedCommand.ExecuteExternalAsync(default(TRequest));
        }

        public static async Task<TResult> ExecuteAsync<TRequest, TResult>(this IAsyncAspCommand<TRequest, TResult> command, IAsyncAspCommand<TRequest, TResult> injectedCommand, TRequest request)
        { 
            return await injectedCommand.ExecuteExternalAsync(request);
        }

    }
}
