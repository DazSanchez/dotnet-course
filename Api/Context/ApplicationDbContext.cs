using Api.Entities;

using Microsoft.EntityFrameworkCore;

namespace Api.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}