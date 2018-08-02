using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyCommand.AspNetCore;
using EasyCommand.Examples.AspNetCore.Commands.AsyncValues;
using Microsoft.AspNetCore.Mvc;

namespace EasyCommand.Examples.AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsyncValuesController : CommandController
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            return await ExecuteCommandAsync(new GetCommand());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return await ExecuteCommandAsync(new GetCommandParamId(), id);
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] string value)
        {
            await ExecuteCommandAsync(new PostCommand(), value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] string value)
        {
            await ExecuteCommandAsync(new PutCommand(), new PutCommandRequest(id, value));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await ExecuteCommandAsync(new DeleteCommand(), id);
        }
    }
}
