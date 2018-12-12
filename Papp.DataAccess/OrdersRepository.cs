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

      
             public IEnumerable<Orders> getUserOrderAddressId(int UserOrderAddressId){
        using (var db = new PizzaDB2Context()){
                return db.Orders.Where(o => o.UserOrderAddressID == UserOrderAddressId);
            }}
        public IEnumerable<Orders> getStoreAddressID(int StoreAddressId){
        using (var db = new PizzaDB2Context()){
                return db.Orders.Where(o => o.StoreAddressID == StoreAddressId);
}
}
   
        //need to be using ef clauses dbcontext here
        




        public IEnumerable<Orders> getId(int Id){
            using (var db = new PizzaDB2Context()) {
            return db.Orders.Where(o => o.Id ==Id);
}
         


    }
}