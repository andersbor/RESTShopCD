using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTShop.Managers;
using RESTShop.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesItemsController : ControllerBase
    {
        private readonly SalesItemManager _manager = new SalesItemManager();

        // GET: api/<SalesItemsController>
        [HttpGet]
        public IEnumerable<SalesItem> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<SalesItemsController>/5
        [HttpGet("{id}")]
        public SalesItem Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<SalesItemsController>
        [HttpPost]
        public SalesItem Post([FromBody] SalesItem value)
        {
            return _manager.Add(value);
        }

        // PUT api/<SalesItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SalesItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
