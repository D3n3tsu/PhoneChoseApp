using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneCoseApp.Entities
{
    public class PhoneCoseAppDbContext : DbContext
    {
        public PhoneCoseAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Phone> Phones { get; set; }
    }
}
