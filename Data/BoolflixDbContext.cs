using csharp_boolfix.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolfix.Data
{
    public class BoolflixDbContext : IdentityDbContext<IdentityUser>
    {

            public DbSet<ContenutoVideo> ContenutiVideo { get; set; }

            public DbSet<Film> Films { get; set; }
            public DbSet<Serie> Series { get; set; }

            public DbSet<Genere> Generi { get; set; }

            public DbSet<PlayList> PlayLists { get; set; }

            public DbSet<Profilo> Profili { get; set; }


        public BoolflixDbContext(DbContextOptions<BoolflixDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("BoolfixDbContextConnection", builder =>
        //    {
        //        builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
        //    });
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
