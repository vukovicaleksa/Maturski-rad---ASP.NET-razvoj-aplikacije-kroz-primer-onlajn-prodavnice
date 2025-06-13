using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Maturski_rad___ASP.NET_razvoj_aplikacije_kroz_primer_onlajn_prodavnice.Models
{
    [PrimaryKey(nameof(Id))]
    public class Proizvod
    {
        [Key]
        public int Id { get; set; }

        public string Ime { get; set; }

        
        public enum Kategorije
        {
            Nijedna,
            Bela_tehnika = 1,
            Racunari = 2,
            TV_audio_video = 3
        }
        public Kategorije Kategorija { get; set; }
        public double Cena { get; set; }

        public Proizvod()
        {
            Ime = "???";
            Kategorija = Kategorije.Nijedna;
            Cena = 0;
            //Id++;
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
