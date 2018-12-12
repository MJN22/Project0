using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

public interface IOrdersRepository
{
	public IOrdersRepository()
	{
        Orders getUserOrderAddressId();

        Orders getStoreAddressId();

        Orders getId();
         
    }
}
