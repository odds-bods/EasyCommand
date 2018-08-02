using System;
using System.Threading.Tasks;

namespace EasyCommand.Examples.ConsoleApp.Commands
{
    public class AsyncOutputPlatformCommand : AsyncCommandNoRequestNoResult
    {
        protected override Task<EmptyCommandResult> ExecuteAsync(EmptyCommandRequest request)
        {
            Console.WriteLine($"{nameof(Environment.OSVersion)} = {Environment.OSVersion}");

            return EmptyResult;
        }
    }
}
