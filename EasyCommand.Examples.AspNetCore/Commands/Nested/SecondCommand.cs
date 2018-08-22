using System.Threading.Tasks;
using EasyCommand.AspNetCore;
using EasyCommand.Examples.AspNetCore.Services;

namespace EasyCommand.Examples.AspNetCore.Commands.Nested
{
    public class SecondCommand : AsyncAspCommand<int, int>
    {
        private readonly IRandomService randomService;

        public SecondCommand(IRandomService randomService)
        {
            this.randomService = randomService;
        }

        protected override Task<int> ExecuteCommandAsync(int request)
        {
            return Task.FromResult(request + randomService.Next());
        }
    }
}
