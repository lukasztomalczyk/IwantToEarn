using System;
using IwantToEarn.DbConfig;
using Microsoft.EntityFrameworkCore;

namespace IwantToEarn.services
{
    public class DbApplicationContext : DbContext
    {
        public DbApplicationContext(DbContextOptions<DbApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<JobModel> JobModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JobModelConfig());
        }
    }
}
