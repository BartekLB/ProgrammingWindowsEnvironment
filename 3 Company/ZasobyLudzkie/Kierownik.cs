using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZasobyLudzkie
{
    class Kierownik : Osoba
    {
        public decimal PensjaMiesieczna { get; set; }
        public decimal ProcentPremii { get; set; }
        public decimal DodatekKierowniczy { get; set; }
        public string NumerTelefonu { get; set; }
        public string NumerTelefonuKomorkowego { get; set; }
        public string NumerPokoju { get; set; }
        public string NazwaDzialu { get; set; }

        public Kierownik(string imie, string nazwisko, int rokUrodzenia, decimal pensjaMiesieczna,
            decimal procentPremii, decimal dodatekKierowniczy, string numerTelefonu, string numerTelefonuKomorkowego, 
            string numerPokoju, string nazwaDzialu) : base(imie, nazwisko, rokUrodzenia)
        {
            PensjaMiesieczna = pensjaMiesieczna;
            ProcentPremii = procentPremii;
            DodatekKierowniczy = dodatekKierowniczy;
            NumerTelefonu = numerTelefonu;
            NumerTelefonuKomorkowego = numerTelefonuKomorkowego;
            NumerPokoju = numerPokoju;
            NazwaDzialu = nazwaDzialu;
        }
        public override string ZwrocInformacje()
        {
            return $"{base.ZwrocInformacje()}, kierownik, pensja miesięczna: {PensjaMiesieczna}, " +
                $"procent premii: {ProcentPremii}, dodatek kierowniczy: {DodatekKierowniczy}, " +
                $"numer telefonu: {NumerTelefonu}, numer telefonu komórkowego: {NumerTelefonuKomorkowego}," +
                $"numer pokoju: {NumerPokoju}, nazwa dzialu: {NazwaDzialu}";
        }

        public decimal PoboryMiesieczne()
        {
            return PensjaMiesieczna + (ProcentPremii * PensjaMiesieczna) + DodatekKierowniczy;
        }
    }
}
