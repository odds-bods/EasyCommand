namespace EasyCommand.AspNetCore
{
    public abstract class AsyncAspCommand<TRequest, TResult> : AsyncCommand<TRequest, TResult>, IAsyncAspCommand<TRequest, TResult>
    {
        protected CommandController Context { get; private set; }

        public IAsyncAspCommand<TRequest, TResult> SetContext(CommandController context)
        {
            Context = context;
            return this;
        }
    }

    public abstract class AsyncAspCommandNoRequest<TResult> : AsyncAspCommand<EmptyCommandRequest, TResult>
    {
        public static readonly EmptyCommandRequest EmptyRequest = default(EmptyCommandRequest);
    }

    public abstract class AsyncAspCommandNoResult<TRequest> : AsyncAspCommand<TRequest, EmptyCommandResult>
    {
        public static readonly EmptyCommandResult EmptyResult = default(EmptyCommandResult);
    }

    public abstract class AsyncAspCommandNoRequestNoResult : AsyncAspCommand<EmptyCommandRequest, EmptyCommandResult>
    {
        public static readonly EmptyCommandRequest EmptyRequest = default(EmptyCommandRequest);
        public static readonly EmptyCommandResult EmptyResult = default(EmptyCommandResult);
    }
}
