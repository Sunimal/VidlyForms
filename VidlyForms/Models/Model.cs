using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidlyForms.Models
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }  
    }    
}
