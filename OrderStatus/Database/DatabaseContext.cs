using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderStatus.Database.Entities;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace OrderStatus.Database
{
    public class DatabaseContext :DbContext
    {
        public DbSet<Statu> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=DESKTOP\SQLEXPRESS; initial catalog=OrderStatus;integrated security=true;");
        }
    }
}
