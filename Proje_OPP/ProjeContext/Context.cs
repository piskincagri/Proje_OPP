using Microsoft.EntityFrameworkCore;
using Proje_OPP.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_OPP.ProjeContext
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer ("server=LAPTOP-L4Q67A3E\\HUSNUCAP;database=DBNewOopCore;uid=sa;pwd=1");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
         public DbSet<Category>  Categories { get; set; }

}
}
