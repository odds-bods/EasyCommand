using System.Threading.Tasks;

namespace EasyCommand
{
    public interface IAsyncCommand
    {
    }

    public interface IAsyncCommand<TRequest, TResult> : IAsyncCommand
    {
        Task<TResult> ExecuteExternalAsync(TRequest request);
    }
}
