﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

namespace Papp.DataAccess
{
	public interface IOrdersRepository
	{
        Orders getUserOrderAddressId();

        Orders getStoreAddressId();

        Orders getId();
         
    }
}
