using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Czasopismo : MaterialBiblioteczny
    {
        public int Numer { get; set; }
        public int RokWydania { get; set; }
        public string Rodzaj { get; set; }

        public Czasopismo(string tytul, int numer, int rokWydania, string rodzaj) : base("Czasopismo", tytul)
        {
            Numer = numer;
            RokWydania = rokWydania;
            Rodzaj = rodzaj;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Numer: {Numer}, Rok Wydania: {RokWydania}, Rodzaj: {Rodzaj}";
        }
        public override string ToFileLine()
        {
            return $"{base.ToFileLine()},{Numer},{RokWydania},{Rodzaj}";
        }
    }
}
