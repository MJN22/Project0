using Microsoft.EntityFrameworkCore;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Papp.DataAccess
{
	public class PizzaRepository : IPizzaRepository
	{

        public PizzaDB2Context Db { get => db; set => db = value; }

        private PizzaDB2Context db;

        public IEnumerable<PizzaRepository> getId(int Id)
        {
            using (var db = new PizzaDB2Context())
            {
                return db.PizzaRepository.Where(o => o.Id == Id);
            }
        }

    }
}
