using Microsoft.EntityFrameworkCore;
using RestaurantReviews.Library;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Papp.DataAccess
{
   public class OrderedPizzasRepository : IOrderedPizzasRepository
{
        public PizzaDB2Context Db {get;}

        public OrderedPizzasRepository(OrderedPizzasRepository db)
{
        Db = db;
}

        OrderedPizzas getIdOrderedPizzas(int Id){
            return Id;
}
        OrderedPizzas getIdOrderedPizzas(int OrderId)
{
            return OrderId;
}    
        OrderedPizzas getPizzaIdOrderedPizza(int PizzaId){
            return PizzaId;
}


}
}
      
    

