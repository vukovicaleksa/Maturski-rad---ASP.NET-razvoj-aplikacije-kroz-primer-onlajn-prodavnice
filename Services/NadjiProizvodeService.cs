using Maturski_rad___ASP.NET_razvoj_aplikacije_kroz_primer_onlajn_prodavnice.Models;
using System.Text.Json;
using System.Data;
using System.Data.OleDb;

namespace Maturski_rad___ASP.NET_razvoj_aplikacije_kroz_primer_onlajn_prodavnice.Services
{
    public class NadjiProizvodeService
    {
        public NadjiProizvodeService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
            oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                WebHostEnvironment.WebRootPath + "\\data\\Baza.accdb;Persist Security Info=True");
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public OleDbConnection oleDbConnection { get; }

        private string LokacijaBaze
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Baza.accdb"); }
        }

        public IEnumerable<Proizvod> ListaProizvoda()
        {
            return null;
        }
    }
}
