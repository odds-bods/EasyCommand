namespace EasyCommand.AspNetCore
{
    public interface IAspCommand<TRequest, TResult> : ICommand<TRequest, TResult>
    {
        IAspCommand<TRequest, TResult> SetContext(CommandController commandController);
    }
}
