
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeOrder.Database.Entities;

namespace MakeOrder.Database
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=DESKTOP\SQLEXPRESS; initial catalog=MakeOrderMicroservice;integrated security=true;");
        }

    }
}
