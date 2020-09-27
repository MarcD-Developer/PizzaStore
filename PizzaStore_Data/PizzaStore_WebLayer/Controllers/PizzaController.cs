using PizzaStore_BusinessLayer;
using PizzaStore_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PizzaStore_WebLayer.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PizzaController : ApiController
    {
        PizzaLogic pizzaLogic = new PizzaLogic();
        // GET: api/Pizza
        public IEnumerable<Pizza> Get()
        {
            return pizzaLogic.getPizza();
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
