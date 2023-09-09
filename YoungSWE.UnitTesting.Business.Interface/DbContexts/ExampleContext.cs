using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungSWE.UnitTesting.Domain.Models;

namespace YoungSWE.UnitTesting.Domain.DbContexts
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .ToTable("People")
                .HasKey(x => x.ID);
        }

        public virtual DbSet<Person> Persons { get; set; }

    }
}
