using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZasobyLudzkie
{
    class Praktykant : Osoba
    {
        public Osoba Opiekun { get; set; }
        public bool CzyPrzyznaneStypendium { get; set; }

        public Praktykant(string imie, string nazwisko, int rokUrodzenia, Osoba opiekun,
            bool czyPrzyznaneStypendium) : base(imie, nazwisko, rokUrodzenia)
        {
            Opiekun = opiekun;
            CzyPrzyznaneStypendium = czyPrzyznaneStypendium;
        }

        public override string ZwrocInformacje()
        {
            string stypendiumNapis = "Nie";
            if (CzyPrzyznaneStypendium) stypendiumNapis = "Tak";

            return $"{base.ZwrocInformacje()}, praktykant, opiekun: {Opiekun.Imie} {Opiekun.Nazwisko}, " +
                $"Stypendium: {stypendiumNapis}";
        }

        public decimal PoboryMiesieczne()
        {
            if (CzyPrzyznaneStypendium) return Globalne.kwotaStypendium;
            return 0;
        }
    }
}
