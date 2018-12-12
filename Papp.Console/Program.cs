using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Papp.DataAccess;

namespace Papp.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
             var optionsBuilder = new DbContextOptionsBuilder<>();
            optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);
            var options = optionsBuilder.Options;

            var dbContext = new PizzaDB2Context(options);
            IOrderedPizzasRepository OrderedPizzasRepository = new OrderedPizzasRepository(dbContext);
          //  var serializer = new XmlSerializer(typeof(List<OrderedPizzas>));

        public DbSet<OrderedPizzas> OrderedPizzas{get;set;}
        //pretty sure this is wrong focus onrepos
        //http://www.entityframeworktutorial.net/efcore/entity-framework-core-dbcontext.aspx
           
            
        }
    }
}
