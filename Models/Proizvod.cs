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
    public class Popust
    {
        public int Id { get; }
        public double Procenat { get; }
        public DateOnly Pocetak { get; }
        public DateOnly Kraj { get; }

        public Popust()
        {
            Procenat = 0;
            Pocetak = DateOnly.FromDateTime(DateTime.Today.Date);
            Kraj = DateOnly.FromDateTime(DateTime.Today.Date);
            Id++;
        }

        public Popust(int id, double procenat, DateOnly kraj, DateOnly? pocetak)
        {
            Id = id;
            if (procenat > 0)
            {
                Console.Error.WriteLine("Procenat popusta je veći od nula. Pretpostavljamo da je greška u znaku. Biće prikazano smanjenje cene umesto njenog povećanja");
                procenat = -procenat;
            }
            if (pocetak == null)
            {
                Console.WriteLine("Nije unet početni datum popusta. Podrazumevana vrednost će biti današnji datum.");
                pocetak = DateOnly.FromDateTime(DateTime.Now);
            }
            if (kraj < pocetak)
            {
                Console.Error.WriteLine("Završni datum popusta je pre početnog. Pretpostavljamo da treba obrnuti redosled.");
                DateOnly __sacuvaj = kraj;
                kraj = (DateOnly)pocetak; //Da se ne žali za "?", svakako neće biti null jer je to već provereno.
                pocetak = __sacuvaj;
            }
            Procenat = procenat;
            Pocetak = (DateOnly)pocetak; //Isto, da se ne žali na null.
            Kraj = kraj;
        }

    }
    [PrimaryKey(nameof(Id))]
    public class Proizvod
    {
        public int Id { get; }

        public string Ime { get; }

        public Kategorije Kategorija { get; }

        public double Cena { get; }

        public Popust PopustNaProizvod { get; }

        public Proizvod()
        {
            Ime = "???";
            Kategorija = Kategorije.Nijedna;
            Cena = 0;
            PopustNaProizvod = new Popust();
            Id++;//Proveri da li ovo radi ne secam se
        }
        public Proizvod(int id, string ime, Kategorije kategorija, double cena, Popust? popustNaProizvod)
        {
            Id = id;
            Ime = ime;
            Kategorija = kategorija;
            Cena = cena;
            if (PopustNaProizvod == null)
            {
                PopustNaProizvod = new Popust();
            }
            else
            {
                PopustNaProizvod = popustNaProizvod;
            }
        }
        public Proizvod(int id, string ime, Kategorije kategorija, double cena, double procenatPopusta, DateOnly pocetakPopusta, DateOnly krajPopusta)
        {
            Id = id;
            Ime = ime;
            Kategorija = kategorija;
            Cena = cena;
            PopustNaProizvod = new Popust(id, procenatPopusta, krajPopusta, pocetakPopusta);
        }
    }
}
