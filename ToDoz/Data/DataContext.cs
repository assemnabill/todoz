using System;
using ToDoz.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ToDoz.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            //..
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserProfileViewModel> Users { get; set; }
        public DbSet<TaskViewModel> Tasks { get; set; }
    }
}
