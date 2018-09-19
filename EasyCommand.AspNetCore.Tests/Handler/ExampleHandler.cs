using System.Threading.Tasks;

namespace EasyCommand.AspNetCore.Tests.Handler
{
    class ExampleHandler : IAsyncAspCommandHandler
    {
        public Task<TResult> ExecuteCommand<TRequest, TResult>(IAsyncAspCommand<TRequest, TResult> command, TRequest request)
        {
            return Task.FromResult(default(TResult));
        }
    }
}
