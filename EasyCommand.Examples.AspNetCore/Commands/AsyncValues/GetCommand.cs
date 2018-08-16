using EasyCommand.AspNetCore;
using EasyCommand.Examples.AspNetCore.Services;
using System.Threading.Tasks;

namespace EasyCommand.Examples.AspNetCore.Commands.AsyncValues
{
    public class GetCommand : AsyncAspCommandNoRequest<string[]>
    {
        public GetCommand(ISomeService someService)
        {
        }

        protected override Task<string[]> ExecuteAsync(EmptyCommandRequest request)
        {
            return Task.FromResult(new string[] { "value1", "value2" });
        }
    }
}
