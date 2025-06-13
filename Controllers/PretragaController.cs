using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Maturski_rad___ASP.NET_razvoj_aplikacije_kroz_primer_onlajn_prodavnice.Controllers
{
    public class PretragaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pretrazi(string tekstPretrage)
        {
            Console.WriteLine(tekstPretrage);

            ViewData["TekstPretrage"] = tekstPretrage; //ViewData mozda nije najbolji izbor za ovo
            return View("../_RezultatiPretrage");
        }
    }
}
