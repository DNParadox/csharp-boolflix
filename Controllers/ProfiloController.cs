using csharp_boolfix.Data;
using Microsoft.AspNetCore.Mvc;


namespace csharp_boolfix.Controllers
{
    public class ProfiloController : Controller
    {
        BoolfixDbContext db;



        public IActionResult Index()
        {
            return View();
        }
    }
}
