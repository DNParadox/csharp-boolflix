using csharp_boolfix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolfix.Data
{
    public class BoolfixDbContext : IdentityDbContext<IdentityUser>
    {

            public BoolfixDbContext
                (DbContextOptions<BoolfixDbContext> options) : base (options)
            {
            }
            public DbSet<ContenutoVideo> ContenutiVideo { get; set; }

            public DbSet<Film> Films { get; set; }
            public DbSet<Serie> Series { get; set; }

            public DbSet<Genere> Generi { get; set; }

            public DbSet<PlayList> PlayLists { get; set; }

            public DbSet<Profilo> Profili { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
