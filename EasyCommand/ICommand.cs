namespace EasyCommand
{
    public interface ICommand<TRequest, TResult>
    {
        TResult ExecuteCommand(TRequest request);
    }
}
