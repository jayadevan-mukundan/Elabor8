using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFactService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CatFactService.Data
{
    public class CatFactContext : DbContext
    {
        public CatFactContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<CatFact> CatFacts { get; set; }

        public DbSet<Source> Sources { get; set; }

        public DbSet<Models.Type> Types { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
