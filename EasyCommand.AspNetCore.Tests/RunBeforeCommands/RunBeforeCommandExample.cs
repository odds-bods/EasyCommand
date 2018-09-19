using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyCommand.AspNetCore.Tests
{
    class RunBeforeCommandExample : IRunBeforeCommand
    {
        public Task BeforeExecutionOfCommand()
        {
            return Task.CompletedTask;
        }
    }
}
