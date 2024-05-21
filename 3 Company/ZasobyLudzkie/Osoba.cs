using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZasobyLudzkie
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int RokUrodzenia { get; set; }

        public Osoba(string imie, string nazwisko, int rokUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            RokUrodzenia = rokUrodzenia;
        }

        public virtual string ZwrocInformacje()
        {
            return $"{Imie} {Nazwisko}, {RokUrodzenia}";
        }
    }
}
