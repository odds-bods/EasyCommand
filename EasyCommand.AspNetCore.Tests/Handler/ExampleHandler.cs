using System;
using System.Threading.Tasks;

namespace EasyCommand.AspNetCore.Tests.Handler
{
    class ExampleHandler : IAsyncAspCommandHandler
    {
        public Task AfterExecutionAsync<TResponse>(Type command, TResponse response)
        {
            return Task.CompletedTask;
        }

        public Task BeforeExecutionAsync<TRequest>(Type command, TRequest request)
        {
            return Task.CompletedTask;
        }

    }
}
