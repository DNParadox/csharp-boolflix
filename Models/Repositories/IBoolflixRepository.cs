using csharp_boolfix.Models;
using Microsoft.Extensions.Hosting;

namespace csharp_boolfix.Models.Repositories
{
    public interface IBoolflixRepository
    {
        List<Profilo> All();

        Profilo GetById(int Id);

        void Create(Profilo createProfile);

        void Update(Profilo createProfile,Profilo updatedProfile);

        void Delete(Profilo profileToDelete);
    }
}
