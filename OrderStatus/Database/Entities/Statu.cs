using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DocumentFormat.OpenXml.Drawing.Diagrams;



namespace OrderStatus.Database.Entities
{
    public class Statu

    {
        [Key]
        public int OrderId { get; set; }
        public string OrderState { get; set; }
    }
}
