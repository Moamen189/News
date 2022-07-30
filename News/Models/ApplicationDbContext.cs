using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace News.Models
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser, ApplicationRole , string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{

        //}
        public DbSet<Post> Posts { get; set; }
        public DbSet<Catogery> Catogeries { get; set; }
    }
}
