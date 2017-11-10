using System.Collections.Generic;
using System.Threading.Tasks;
using Hse.Application.Contracts;
using Hse.Application.Services;
using Hse.Validation;
using Microsoft.AspNetCore.Mvc;
using Rebus.Bus;

namespace Trader.Api.Controllers
{
    [Route("api/warehouses"), ValidateModel]
    public class WarehouseController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateWarehouseModel model, [FromServices] IBus bus)
        {
            var command = WarehouseCommand.ToCreateCommand(model);

            await bus.Send(command).ConfigureAwait(false);

            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
