using IztekTestCase.Models;
using Microsoft.EntityFrameworkCore;

namespace IztekTestCase.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Input> Inputs { get; set; }
    }
}
