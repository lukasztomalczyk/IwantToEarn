using System;
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
    }
}
