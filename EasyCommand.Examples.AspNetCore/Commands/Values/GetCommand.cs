using EasyCommand.AspNetCore;
using System.Threading.Tasks;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class GetCommand : AsyncAspCommandNoRequest<string[]>
    {
        protected override Task<string[]> ExecuteCommandAsync(EmptyCommandRequest request)
        {
            return Task.FromResult(new string[] { "value1", "value2" });
        }
    }
}
