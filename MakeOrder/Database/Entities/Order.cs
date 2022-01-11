using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MakeOrder.Database.Entities
{
    public class Order
    {

        [Key]
        public string FoodId { get; set; } 
        public int Qte { get; set; }
        public string ClientId { get; set; }
        public string ClientAdresse { get; set; } 
        public string Contact { get; set; } 
        
 
   }
    
}
