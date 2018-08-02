namespace EasyCommand.AspNetCore
{
    public interface IAsyncAspCommand<TRequest, TResult> : IAsyncCommand<TRequest, TResult>
    {
        IAsyncAspCommand<TRequest, TResult> SetContext(CommandController commandController);
    }
}
