using EasyCommand.AspNetCore;
using System.Threading.Tasks;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class PostCommand : AsyncAspCommandNoResult<string>
    {
        protected override Task<EmptyCommandResult> ExecuteCommandAsync(string request)
        {
            return Task.FromResult(default(EmptyCommandResult));
        }
    }
}
