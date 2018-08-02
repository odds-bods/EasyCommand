namespace EasyCommand
{
    public abstract class Command<TRequest, TResult> : ICommand<TRequest, TResult>
    {
        public TResult ExecuteCommand(TRequest request)
        {
            return Execute(request);
        }

        protected abstract TResult Execute(TRequest request);
    }

    public abstract class CommandNoRequest<TResult> : Command<EmptyCommandRequest, TResult>
    {
        public static readonly EmptyCommandRequest EmptyRequest = default(EmptyCommandRequest);
    }

    public abstract class CommandNoResult<TRequest> : Command<TRequest, EmptyCommandResult>
    {
        public static readonly EmptyCommandResult EmptyResult = default(EmptyCommandResult);
    }

    public abstract class CommandNoRequestNoResult : Command<EmptyCommandRequest, EmptyCommandResult>
    {
        public static readonly EmptyCommandRequest EmptyRequest = default(EmptyCommandRequest);
        public static readonly EmptyCommandResult EmptyResult = default(EmptyCommandResult);
    }
}
