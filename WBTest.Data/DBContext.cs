using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBTest.Models;

namespace WBTest.Data
{
    public class DBContext : IdentityDbContext<Customer>
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

     

        public DbSet<Customer> Customers { get; set; }
    }
}
