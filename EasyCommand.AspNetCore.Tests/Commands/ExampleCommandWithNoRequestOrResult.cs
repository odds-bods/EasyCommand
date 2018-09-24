using System.Threading.Tasks;

namespace EasyCommand.AspNetCore.Tests.Commands
{
    class ExampleCommandWithNoRequestOrResult : AsyncAspCommandNoRequestNoResult
    {

        public ExampleCommandWithNoRequestOrResult()
        {
        }
           
        protected override Task<EmptyCommandResult> ExecuteCommandAsync(EmptyCommandRequest request)
        {
            return Task.FromResult(new EmptyCommandResult());
        }
    }
}
