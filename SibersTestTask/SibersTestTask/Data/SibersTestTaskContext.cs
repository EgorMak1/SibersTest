using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SibersTestTask.Models;

namespace SibersTestTask.Data
{
    public class SibersTestTaskContext : DbContext
    {
        public SibersTestTaskContext (DbContextOptions<SibersTestTaskContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leader> Leaders { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employess_Projects> Employess_Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<Leader>().ToTable("Leader");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Employess_Projects>().ToTable("Employess_Projects");

        }

        public DbSet<SibersTestTask.Models.Project> Project { get; set; } = default!;
    }
}
