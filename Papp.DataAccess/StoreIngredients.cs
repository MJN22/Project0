using System;
using System.Collections.Generic;

namespace Papp.DataAccess
{
    public partial class StoreIngredients
    {
        public int StoreIngredientsAddressId { get; set; }
        public int Id { get; set; }
        public int? IngredientStock { get; set; }

        public virtual Store StoreIngredientsAddress { get; set; }
    }
}
