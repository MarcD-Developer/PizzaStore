using PizzaStore_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore_BusinessLayer
{
    public class PizzaLogic
    {
        PizzaList pizzaRepo;

        public PizzaLogic()
        {
            pizzaRepo = new PizzaList();
        }

        public IEnumerable<Pizza> getPizza()
        {
            IEnumerable<Pizza> getPizzaList = pizzaRepo.getAllPizzas();
            return getPizzaList;
        }
    }
}
