using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EasyCommand.AspNetCore.Tests.Commands
{
    class ExampleCommandWithRequestAndResult : AsyncAspCommand<int,int>
    {
        protected override Task<int> ExecuteCommandAsync(int request)
        {
            return Task.FromResult(request);
        }
    }
}
