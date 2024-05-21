using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class MaterialBiblioteczny
    {
        public string Typ { get; set; }
        public string Tytul { get; set; }

        public MaterialBiblioteczny(string typ, string tytul) {
            Typ = typ;
            Tytul = tytul;
        }
        public override string ToString()
        {
            return $"Typ: {Typ}, Tytuł: {Tytul}";
        }
        public virtual string ToFileLine()
        {
            return $"{Typ},{Tytul}";
        }
    }
}
