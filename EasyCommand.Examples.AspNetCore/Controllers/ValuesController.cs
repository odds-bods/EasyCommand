using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyCommand.AspNetCore;
using EasyCommand.Examples.AspNetCore.Commands.Values;
using Microsoft.AspNetCore.Mvc;

namespace EasyCommand.Examples.AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : CommandController
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return ExecuteCommand(new GetCommand());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return ExecuteCommand(new GetCommandParamId(), id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            ExecuteCommand(new PostCommand(), value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            ExecuteCommand(new PutCommand(), new PutCommandRequest(id, value));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ExecuteCommand(new DeleteCommand(), id);
        }
    }
}
