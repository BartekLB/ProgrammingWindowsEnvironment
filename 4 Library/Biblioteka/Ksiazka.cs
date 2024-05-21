using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ksiazka : MaterialBiblioteczny
    {
        public string Autor { get; set; }
        public int RokWydania { get; set; }
        public string Wydawnicstwo { get; set; }
        public string ISBN { get; set; }

        public Ksiazka(string tytul, string autor, int rokWydania, string wydawnicstwo, string isbn) : base("Książka", tytul)
        {
            Autor = autor;
            RokWydania = rokWydania;
            Wydawnicstwo = wydawnicstwo;
            ISBN = isbn;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Autor/Autorzy: {Autor}, Rok Wydania: {RokWydania}, Wydawnicstwo: {Wydawnicstwo}, ISBN: {ISBN}";
        }
        public override string ToFileLine()
        {
            return $"{base.ToFileLine()},{Autor},{RokWydania},{Wydawnicstwo},{ISBN}";
        }
    }
    
}
