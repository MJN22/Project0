using Microsoft.EntityFrameworkCore;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Papp.DataAccess
{
    public class OrdersRepository : IOrdersRepository
    {
        public PizzaDB2Context Db;
        public OrdersRepository(PizzaDB2Context db)
        {
            Db = db;
        }

        public Orders getUserOrderAddressId(int UserOrderAddressId){
            
            }

        public Orders getStoreAddressId(int StoreAddressId);

        public Orders getId(int id);

    }
}