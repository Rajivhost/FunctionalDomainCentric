using System.Collections.Generic;
using Hse.Application.Contracts;
using Hse.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Trader.Api.Controllers
{
    [Route("api/warehouses")]
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
        public void Post([FromBody]CreateWarehouseModel model, [FromServices] IWarehouseService service)
        {
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
