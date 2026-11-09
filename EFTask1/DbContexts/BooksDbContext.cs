using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTask1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTask1.DbContexts
{
    internal class BooksDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=EFCoreTask1;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
