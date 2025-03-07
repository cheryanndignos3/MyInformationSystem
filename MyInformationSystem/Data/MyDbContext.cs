using Microsoft.EntityFrameworkCore;
using MyInformationSystem.Models;

namespace MyInformationSystem.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> students { get; set; }
    }
}
