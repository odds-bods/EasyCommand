using System.Threading.Tasks;
using EasyCommand.AspNetCore;

namespace EasyCommand.Examples.AspNetCore.Commands.Nested
{
    public class SecondCommand : AsyncAspCommand<int, int>
    {
        protected override Task<int> ExecuteCommandAsync(int request)
        {
            return Task.FromResult(request);
        }
    }
}
