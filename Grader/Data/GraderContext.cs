using Grader.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace Grader.Data
{
    public class GraderContext : DbContext
    {
        public GraderContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Record> Records { get; set; }
        public DbSet<Student> Students { get; set; }


    }
}
