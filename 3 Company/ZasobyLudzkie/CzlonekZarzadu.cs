using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZasobyLudzkie
{
    class CzlonekZarzadu : Osoba
    {
        public decimal PensjaMiesieczna { get; set; }
        public Osoba Asystent { get; set; }
        public int IloscSpotkanRadyNadzorczej { get; set; }

        public CzlonekZarzadu(string imie, string nazwisko, int rokUrodzenia, decimal pensjaMiesieczna,
            Osoba asystent, int iloscSpotkanRadyNadzorczej)
            : base(imie, nazwisko, rokUrodzenia)
        {
            PensjaMiesieczna = pensjaMiesieczna;
            Asystent = asystent;
            IloscSpotkanRadyNadzorczej = iloscSpotkanRadyNadzorczej;
        }
        public override string ZwrocInformacje()
        {
            return $"{base.ZwrocInformacje()}, członek zarządu, pensja miesięczna: {PensjaMiesieczna}, " +
                $"asystent: {Asystent.Imie} {Asystent.Nazwisko}, ilość spotkań RN: {IloscSpotkanRadyNadzorczej}";
        }

        public decimal PoboryMiesieczne()
        {
            return PensjaMiesieczna + (IloscSpotkanRadyNadzorczej * Globalne.kwotaZaSpotkanieRN);
        }
    }
}
