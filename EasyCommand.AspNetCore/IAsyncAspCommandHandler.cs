using System.Threading.Tasks;

namespace EasyCommand.AspNetCore
{
    public interface IAsyncAspCommandHandler
    {
        Task<TResult> ExecuteCommand<TRequest, TResult>(IAsyncAspCommand<TRequest, TResult> command, TRequest request);
    }
}
