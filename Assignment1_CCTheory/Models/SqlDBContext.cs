using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment1_CCTheory.Models
{
    public class SqlDBContext:DbContext
    {
        public SqlDBContext() : base("name=SqlConnection")  
        {
        }
        public DbSet<Order> Orders { get; set; }
    }

}
