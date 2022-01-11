using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Menu.Database.Entities;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace Menu.Database
{
    public class DatabaseContext : DbContext
    {
 
        public DbSet<Food> Foods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=DESKTOP\SQLEXPRESS; initial catalog=Menu;integrated security=true;");
        }
    }
}
