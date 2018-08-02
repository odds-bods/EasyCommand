﻿using EasyCommand.AspNetCore;
using System.Threading.Tasks;

namespace EasyCommand.Examples.AspNetCore.Commands.AsyncValues
{
    public class GetCommandParamId : AsyncAspCommand<int, string>
    {
        protected override Task<string> ExecuteAsync(int request)
        {
            return Task.FromResult("value");
        }
    }
}
