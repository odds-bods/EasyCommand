using System.Threading.Tasks;
using EasyCommand.AspNetCore;

namespace EasyCommand.Examples.AspNetCore.Commands.Nested
{
    public class FirstCommand : AsyncAspCommand<int, int>
    {
        protected override async Task<int> ExecuteCommandAsync(int request)
        {
            return await this.ExecuteAsync(this.Command<SecondCommand>(), request);
        }
    }
}
