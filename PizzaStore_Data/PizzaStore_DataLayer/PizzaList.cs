using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_DataLayer
{
    public class PizzaList
    {
        public IEnumerable<Pizza> getAllPizzas()
        {
            var ctx = new PizzaStoreEntities();

            var pizzas = from p in ctx.Pizzas
                         select p;

            return pizzas;
        }
    }
}
