using System.Threading.Tasks;

namespace EasyCommand
{
    public class CommandExecutor
    {
        public TResult ExecuteCommand<TResult>(ICommand<EmptyCommandRequest, TResult> command)
        {
            return command.ExecuteCommand(EmptyCommandRequest.Instance);
        }

        public TResult ExecuteCommand<TRequest, TResult>(ICommand<TRequest, TResult> command, TRequest request)
        {
            return command.ExecuteCommand(request);
        }

        public async Task<TResult> ExecuteCommandAsync<TResult>(IAsyncCommand<EmptyCommandRequest, TResult> command)
        {
            return await command.ExecuteCommandAsync(EmptyCommandRequest.Instance);
        }

        public async Task<TResult> ExecuteCommandAsync<TRequest, TResult>(IAsyncCommand<TRequest, TResult> command, TRequest request)
        {
            return await command.ExecuteCommandAsync(request);
        }
    }
}
