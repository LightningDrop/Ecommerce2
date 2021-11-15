﻿using Ecommcerce2.Core.Models;
using System.Data.Entity;


namespace Ecommerce2.EF
{
    public class ShoppingDBContext : DbContext
    {
        public DbSet<ShoppingList>? ShoppingList { get; set; }

        public DbSet<Accounts>? Account { get; set; }



    }


}
