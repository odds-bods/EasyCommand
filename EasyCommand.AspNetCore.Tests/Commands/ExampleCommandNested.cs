using System.Threading.Tasks;

namespace EasyCommand.AspNetCore.Tests.Commands
{
    class ExampleCommandNested : AsyncAspCommandNoRequestNoResult
    {
        public ExampleCommandNested()
        {
        }

        protected override Task<EmptyCommandResult> ExecuteCommandAsync(EmptyCommandRequest request)
        {
            return this.ExecuteAsync(this.Command<ExampleCommandWithNoRequestOrResult>());
        }
    }
}
