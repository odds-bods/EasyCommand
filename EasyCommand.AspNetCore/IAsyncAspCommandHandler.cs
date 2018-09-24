using System;
using System.Threading.Tasks;

namespace EasyCommand.AspNetCore
{
    public interface IAsyncAspCommandHandler
    {
        Task BeforeExecutionAsync<TRequest>(Type command, TRequest request);

        Task AfterExecutionAsync<TResponse>(Type command, TResponse response);
    }
}
