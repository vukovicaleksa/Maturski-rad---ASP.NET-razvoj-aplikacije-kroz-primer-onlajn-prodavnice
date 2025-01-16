using Microsoft.AspNetCore.Mvc;

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
            TempData["pretraga"] = tekstPretrage;
            return View("~/Views/_RezultatiPretrage.cshtml");
        }
    }
}
