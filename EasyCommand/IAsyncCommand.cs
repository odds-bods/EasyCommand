using System.Threading.Tasks;

namespace EasyCommand
{
    public interface IAsyncCommand<TRequest, TResult>
    {
        Task<TResult> ExecuteCommandAsync(TRequest request);
    }
}
