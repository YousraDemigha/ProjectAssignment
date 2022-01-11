using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace Menu.Database.Entities
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }
        public string FoodCategory { get; set; }
        public int FoodQte { get; set; }
        public string FoodComponent { get; set; }
        
    }
}
