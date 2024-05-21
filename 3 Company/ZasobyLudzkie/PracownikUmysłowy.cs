using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZasobyLudzkie
{
    class PracownikUmyslowy : Osoba
    {
        public decimal PensjaMiesieczna { get; set; }
        public decimal ProcentPremii { get; set; }
        public Kierownik Kierownik { get; set; }
        public string NumerTelefonu { get; set; }
        public string NumerPokoju { get; set; }
        public PracownikUmyslowy(string imie, string nazwisko, int rokUrodzenia, decimal pensjaMiesieczna,
        decimal procentPremii, Kierownik kierownik, string numerTelefonu, string numerPokoju) : base(imie, nazwisko, rokUrodzenia)
        {
            PensjaMiesieczna = pensjaMiesieczna;
            ProcentPremii = procentPremii;
            Kierownik = kierownik;
            NumerTelefonu = numerTelefonu;
            NumerPokoju = numerPokoju;
        }
        public override string ZwrocInformacje()
        {
            return $"{base.ZwrocInformacje()}, pracownik umyslowy, pensja miesięczna: {PensjaMiesieczna}, " +
                $"procent premii: {ProcentPremii}, kierownik: {Kierownik.Imie} {Kierownik.Nazwisko}, " +
                $"numer telefonu: {NumerTelefonu}, numer pokoju: {NumerPokoju}";
        }
        public decimal PoboryMiesieczne()
        {
            return PensjaMiesieczna + (ProcentPremii * PensjaMiesieczna);
        }
    }
}
