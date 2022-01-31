using Api.Entities;

using Microsoft.EntityFrameworkCore;

namespace Api.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}