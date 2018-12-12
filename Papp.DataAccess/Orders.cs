using System;
using System.Collections.Generic;

namespace Papp.DataAccess
{
    public partial class Orders
    {
        public Orders()
        {
            OrderedPizzas = new HashSet<OrderedPizzas>();
        }

        public int UserOrderAddressId { get; set; }
        public int StoreAddressId { get; set; }
        public int Id { get; set; }

        public virtual Store StoreAddress { get; set; }
        public virtual UserAddress UserOrderAddress { get; set; }
        public virtual ICollection<OrderedPizzas> OrderedPizzas { get; set; }
    }
}
