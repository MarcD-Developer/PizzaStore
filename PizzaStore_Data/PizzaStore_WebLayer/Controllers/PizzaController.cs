using PizzaStore_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStore_WebLayer.Controllers
{
    public class PizzaController : ApiController
    {
        // GET: api/Pizza
        public IEnumerable<Pizza> Get()
        {
            var pizzaDB = new PizzaList();
            
            return pizzaDB.getAllPizzas();
        }

        // GET: api/Pizza/5
        public string Get(int id)
        {
            return "value";
        }

        //// POST: api/Pizza
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Pizza/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Pizza/5
        //public void Delete(int id)
        //{
        //}
    }
}
