using EasyCommand.AspNetCore;
using System.Threading.Tasks;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class PostCommand : AsyncAspCommand<string, EmptyCommandResult>
    {
        protected override Task<EmptyCommandResult> ExecuteAsync(string request)
        {
            return Task.FromResult(default(EmptyCommandResult));
        }
    }
}
