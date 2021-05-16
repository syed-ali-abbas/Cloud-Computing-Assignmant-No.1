using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Assignment1_CCTheory.Models
{
    [Table("Order")]//syed ali abbas 02-131182-070
    public class Order
    {
        [Key]
        public int OrdId { get; set; }
        public string CusName { get; set; }
        public string Laptop { get; set; }
        public string LCD { get; set; }
        public int Phone { get; set; }
    }
}