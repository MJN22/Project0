using System;
using System.Collections.Generic;

namespace Papp.DataAccess
{
    public partial class Pizza
    {
        public Pizza()
        {
            OrderedPizzas = new HashSet<OrderedPizzas>();
            PizzaIngredients = new HashSet<PizzaIngredients>();
        }

        public int Id { get; set; }
        public string PizzaName { get; set; }
        public decimal Costs { get; set; }

        public virtual ICollection<OrderedPizzas> OrderedPizzas { get; set; }
        public virtual ICollection<PizzaIngredients> PizzaIngredients { get; set; }
    }
}
