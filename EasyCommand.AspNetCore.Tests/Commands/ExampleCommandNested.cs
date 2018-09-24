using System.Threading.Tasks;

namespace EasyCommand.AspNetCore.Tests.Commands
{
    class ExampleCommandNested : AsyncAspCommandNoRequestNoResult
    {
        private TestObject testObject;

        public ExampleCommandNested(TestObject testObject = null)
        {
            if (!(testObject is null)) this.testObject = testObject;
        }

        protected override Task<EmptyCommandResult> ExecuteCommandAsync(EmptyCommandRequest request)
        {
            return this.ExecuteAsync(this.Command<ExampleCommandWithNoRequestOrResult>());
        }
    }
}
