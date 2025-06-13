using Microsoft.EntityFrameworkCore;

namespace Maturski_rad___ASP.NET_razvoj_aplikacije_kroz_primer_onlajn_prodavnice.Models
{
    public enum Kategorije
    {
        Nijedna,
        Bela_tehnika,
        Racunari,
        TV_audio_video
    }

    [PrimaryKey(nameof(Id))]
    public class Proizvod
    {
        
        public int Id { get; set; }

        public string Ime { get; set; }

        public Kategorije Kategorija { get; set; }

        public double Cena { get; set; }

        public Proizvod()
        {
            Ime = "???";
            Kategorija = Kategorije.Nijedna;
            Cena = 0;
            Id++;
        }
        public Proizvod(int id, string ime, Kategorije kategorija, double cena)
        {
            Id = id;
            Ime = ime;
            Kategorija = kategorija;
            Cena = cena;
        }
    }
}
