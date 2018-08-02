using System.Threading.Tasks;

namespace EasyCommand
{
    public abstract class AsyncCommand<TRequest, TResult> : IAsyncCommand<TRequest, TResult>
    {
        public async Task<TResult> ExecuteCommandAsync(TRequest request)
        {
            return await ExecuteAsync(request);
        }

        protected abstract Task<TResult> ExecuteAsync(TRequest request);
    }

    public abstract class AsyncCommandNoRequest<TResult> : AsyncCommand<EmptyCommandRequest, TResult>
    {
        public static readonly EmptyCommandRequest EmptyRequest = default(EmptyCommandRequest);
    }

    public abstract class AsyncCommandNoResult<TRequest> : AsyncCommand<TRequest, EmptyCommandResult>
    {
        public static readonly EmptyCommandResult EmptyResult = default(EmptyCommandResult);
    }

    public abstract class AsyncCommandNoRequestNoResult : AsyncCommand<EmptyCommandRequest, EmptyCommandResult>
    {
        public static readonly EmptyCommandRequest EmptyRequest = default(EmptyCommandRequest);
        public static readonly EmptyCommandResult EmptyResult = default(EmptyCommandResult);
    }
}
