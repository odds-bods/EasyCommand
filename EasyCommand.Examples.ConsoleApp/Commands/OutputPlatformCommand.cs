using System;

namespace EasyCommand.Examples.ConsoleApp.Commands
{
    public class OutputPlatformCommand : CommandNoRequestNoResult
    {
        protected override EmptyCommandResult Execute(EmptyCommandRequest request)
        {
            Console.WriteLine($"{nameof(Environment.OSVersion)} = {Environment.OSVersion}");

            return EmptyResult;
        }
    }
}
