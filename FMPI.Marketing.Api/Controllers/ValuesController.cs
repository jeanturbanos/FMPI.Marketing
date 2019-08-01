using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FMPI.Marketing.Core.Models;
using Newtonsoft.Json;

namespace FMPI.Marketing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private SMFargoContext _context = null;

        public ValuesController()
        {
            _context = new SMFargoContext();
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            
            List<InventoryMaster2> itemList = _context.InventoryMaster2.Take(100).ToList();
            
            //return JsonConvert.SerializeObject();
        }
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
