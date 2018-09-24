using System.Threading.Tasks;

namespace EasyCommand.AspNetCore.Tests.Commands
{
    class ExampleCommandWithNoRequestOrResult : AsyncAspCommandNoRequestNoResult
    {
        private TestObject testObject;

        public ExampleCommandWithNoRequestOrResult(TestObject testObject = null)
        {
            if(!(testObject is null)) this.testObject = testObject;
        }
           
        protected override Task<EmptyCommandResult> ExecuteCommandAsync(EmptyCommandRequest request)
        {
            testObject.Called();
            return Task.FromResult(new EmptyCommandResult());
        }
    }
}
