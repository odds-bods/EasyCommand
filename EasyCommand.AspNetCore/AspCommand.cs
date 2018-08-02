namespace EasyCommand.AspNetCore
{
    public abstract class AspCommand<TRequest, TResult> : Command<TRequest, TResult>, IAspCommand<TRequest, TResult>
    {
        protected CommandController Context { get; private set; }

        public IAspCommand<TRequest, TResult> SetContext(CommandController context)
        {
            Context = context;
            return this;
        }
    }

    public abstract class AspCommandNoRequest<TResult> : AspCommand<EmptyCommandRequest, TResult>
    {
        public static readonly EmptyCommandRequest EmptyRequest = default(EmptyCommandRequest);
    }

    public abstract class AspCommandNoResult<TRequest> : AspCommand<TRequest, EmptyCommandResult>
    {
        public static readonly EmptyCommandResult EmptyResult = default(EmptyCommandResult);
    }

    public abstract class AspCommandNoRequestNoResult : AspCommand<EmptyCommandRequest, EmptyCommandResult>
    {
        public static readonly EmptyCommandRequest EmptyRequest = default(EmptyCommandRequest);
        public static readonly EmptyCommandResult EmptyResult = default(EmptyCommandResult);
    }
}
