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
    public class AsyncValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            return await this.ExecuteAsync(this.Command<GetCommand>());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return await this.ExecuteAsync(this.Command<GetCommandParamId>(), id);
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] string value)
        {
            await this.ExecuteAsync(this.Command<PostCommand>(), value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] string value)
        {
            await this.ExecuteAsync(this.Command<PutCommand>(), new PutCommandRequest(id, value));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await this.ExecuteAsync(this.Command<DeleteCommand>(), id);
        }
    }
}
