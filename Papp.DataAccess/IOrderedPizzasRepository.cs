using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Papp.DataAccess
{
    public interface IOrderedPizzasRepository
    {
        OrderedPizzas getIdOrderedPizzas(int id);

        OrderedPizzas getOrderIdOrder(int OrderId);

       OrderedPizzas getPizzaIdOrderedPizzas(int PizzaId);
    }
}