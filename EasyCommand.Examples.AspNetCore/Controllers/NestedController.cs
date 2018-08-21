using EasyCommand.AspNetCore;
using EasyCommand.Examples.AspNetCore.Commands.Nested;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyCommand.Examples.AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NestedController : ControllerBase
    {
        // GET api/nested/5
        [HttpGet("{id}")]
        public async Task<ActionResult<int>> Get(int id)
        {
            return await this.ExecuteAsync(this.Command<FirstCommand>(), id);
        }
    }
}
