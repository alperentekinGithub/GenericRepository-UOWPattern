using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            String connetc = "server= ;database= ;User Id= ; Password= ; TrustServerCertificate=True;integrated security = true;";


            optionsBuilder.UseSqlServer(connetc);
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
