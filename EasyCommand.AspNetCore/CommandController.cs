using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyCommand.AspNetCore
{
    public abstract class CommandController : ControllerBase
    {
        private CommandExecutor executor;

        public CommandController()
        {
            executor = new CommandExecutor();
        }

        protected TResult ExecuteCommand<TResult>(IAspCommand<EmptyCommandRequest, TResult> command)
        {
            return executor.ExecuteCommand(command);
        }

        protected TResult ExecuteCommand<TRequest, TResult>(IAspCommand<TRequest, TResult> command, TRequest request)
        {
            return executor.ExecuteCommand(command, request);
        }

        protected async Task<TResult> ExecuteCommandAsync<TResult>(IAsyncAspCommand<EmptyCommandRequest, TResult> command)
        {
            return await executor.ExecuteCommandAsync(command);
        }

        protected async Task<TResult> ExecuteCommandAsync<TRequest, TResult>(IAsyncAspCommand<TRequest, TResult> command, TRequest request)
        {
            return await executor.ExecuteCommandAsync(command, request);
        }
    }
}
