using EasyCommand.Examples.ConsoleApp.Commands;
using System;
using Xunit;

namespace EasyCommand.Examples.ConsoleApp.Tests.Commands
{
    public class OutputPlatformCommandTests
    {
        private OutputPlatformCommand subject;

        public OutputPlatformCommandTests()
        {
            subject = new OutputPlatformCommand();
        }

        [Fact]
        public void CanExecute()
        {
            subject.ExecuteCommand(null);
        }
    }
}
