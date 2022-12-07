using csharp_boolfix.Data;
using Microsoft.Build.Framework.Profiler;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.SqlServer.Server;

namespace csharp_boolfix.Models.Repositories
{
    public class DbBoolflixRepository : IBoolflixRepository
    {
        private BoolflixDbContext db;

        public DbBoolflixRepository(BoolflixDbContext _db)
        {
            db = _db;
        }

        // Profile
        public List<Profilo> All()
        {
            return db.Profili.ToList();
        }

        public Profilo GetById(int Id)
        {
            return db.Profili.Where(profile => profile.Id == Id).FirstOrDefault();
           
        }

        public void Create(Profilo createProfile)
        {
            db.Profili.Add(createProfile);
            db.SaveChanges();
        }


        public void Update(Profilo createProfile, Profilo updatedProfile)
        {
            createProfile.Name =  updatedProfile.Name;

            db.SaveChanges();
        }

        public void Delete(Profilo profileToDelete)
        {
            db.Profili.Remove(profileToDelete);
            db.SaveChanges();
        }
    }
}
