using Microsoft.AspNetCore.Mvc;

namespace EasyCommand.AspNetCore
{
    public interface IAsyncAspCommand<TRequest, TResult> : IAsyncCommand<TRequest, TResult>
    {
        IAsyncAspCommand<TRequest, TResult> SetController(ControllerBase controller);
    }
}
