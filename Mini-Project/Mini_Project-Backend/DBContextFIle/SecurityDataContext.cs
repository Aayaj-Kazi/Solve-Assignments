using Microsoft.EntityFrameworkCore;
using Mini_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBContextFile
{
    public class SecurityDataContext : DbContext
    {
        public SecurityDataContext(DbContextOptions<SecurityDataContext> options) : base(options)
        {

        }

        public DbSet<Security> Security { get; set; }

        public DbSet<Quote> Quote { get; set; }
    }
}
