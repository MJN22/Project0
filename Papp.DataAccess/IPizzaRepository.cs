using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

namespace Papp.DataAccess
{
	public interface IPizzaRepository
    {
        Pizza getPizzaId();
        Pizza getPizzaName();
        Pizza getPizzaCosts();



    }
}
