using csharp_boolfix.Data;
using csharp_boolfix.Models;
using csharp_boolfix.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace csharp_boolfix.Controllers
{
    public class ProfiloController : Controller
    {
        private BoolflixDbContext db;

        IBoolflixRepository DbBoolflixRepository; 

        public ProfiloController (IBoolflixRepository _boolflixRepository, BoolflixDbContext _db) : base()
        {
            db = _db;

            DbBoolflixRepository = _boolflixRepository;
        }

        public IActionResult Index()
        {
            List<Profilo> profileList = DbBoolflixRepository.All();


            return View(profileList);
        }


        public IActionResult Detail(int Id)
        {
            Profilo profileDetail = DbBoolflixRepository.GetById(Id);

            return View(profileDetail);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Profilo createProfile)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

        

            if (createProfile == null)
            {
                return NotFound();
            }

            DbBoolflixRepository.Create(createProfile);

            return RedirectToAction("Index");
        }

       
        public IActionResult Update(int Id)
        {
            Profilo updateProfile = DbBoolflixRepository.GetById(Id);

            if(updateProfile == null)
            {
                return NotFound();
            }


            Profilo updatedProfile = new Profilo();

            updatedProfile = updateProfile;

           

            return View(updateProfile);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int Id, Profilo updateProfile)
        {
            updateProfile.Id = Id;

            if (!ModelState.IsValid)
            {
                return View();
            }

            Profilo updatedProfile = DbBoolflixRepository.GetById(Id);

            if (updatedProfile == null)
            {
                return NotFound();
            }


            DbBoolflixRepository.Update(updatedProfile, updateProfile);

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int Id)
        {
            Profilo profileToDelete = DbBoolflixRepository.GetById(Id);

            if(profileToDelete == null)
            {
                return NotFound();
            }

            DbBoolflixRepository.Delete(profileToDelete);

            return RedirectToAction("Index");
        }
    }
}
