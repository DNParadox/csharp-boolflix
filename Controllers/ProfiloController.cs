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
    }
}
