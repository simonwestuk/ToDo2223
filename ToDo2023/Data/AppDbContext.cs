using Microsoft.EntityFrameworkCore;
using ToDo2023.Models;

namespace ToDo2023.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
