﻿using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductApi.Model.Context
{
    public class PostgresContext : DbContext
    {
        public PostgresContext() { }
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

    }
}
