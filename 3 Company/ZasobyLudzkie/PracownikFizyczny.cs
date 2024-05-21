using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZasobyLudzkie
{
    class PracownikFizyczny : Osoba
    {
        public decimal StawkaGodzinowa { get; set; }
        public int LiczbaPrzepracowanychGodzin { get; set; }
        public int LiczbaNadgodzin { get; set; }
        public Kierownik Kierownik { get; set; }
        public string Umiejetnosci { get; set; }

        public PracownikFizyczny(string imie, string nazwisko, int rokUrodzenia, decimal stawkaGodzinowa,
            int liczbaPrzepracowanychGodzin, int liczbaNadgodzin, Kierownik kierownik, string umiejetnosci) : base(imie, nazwisko, rokUrodzenia)
        {
            StawkaGodzinowa = stawkaGodzinowa;
            LiczbaPrzepracowanychGodzin = liczbaPrzepracowanychGodzin;
            LiczbaNadgodzin = liczbaNadgodzin;
            Kierownik = kierownik;
            Umiejetnosci = umiejetnosci;
        }

        public override string ZwrocInformacje()
        {
            return $"{base.ZwrocInformacje()}, pracownik fizyczny, stawka godzinowa: {StawkaGodzinowa}, " +
                $"przepracowane godziny: {LiczbaPrzepracowanychGodzin}, nadgodziny: {LiczbaNadgodzin}, " +
                $"kierownik: {Kierownik.Imie} {Kierownik.Nazwisko}, umiejętności: {Umiejetnosci}";
        }

        public decimal PoboryMiesieczne()
        {
            return StawkaGodzinowa * LiczbaPrzepracowanychGodzin + 1.5m * StawkaGodzinowa * LiczbaNadgodzin;
        }
    }
}
