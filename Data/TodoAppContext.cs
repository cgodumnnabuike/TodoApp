using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class TodoAppContext : IdentityDbContext<IdentityUser>
    {
        public TodoAppContext (DbContextOptions<TodoAppContext> options)
            : base(options)
        {
        }

        public DbSet<TodoApp.Models.TodoTask> Task { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoTask>()
                .HasKey(t => t.TaskId);  // Define the primary key

            base.OnModelCreating(modelBuilder);
        }
    }
}
