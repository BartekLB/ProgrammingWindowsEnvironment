using System;
using System.Collections.Generic;
using System.IO;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MaterialBiblioteczny> baza = new List<MaterialBiblioteczny>();

            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Biblioteka - wybierz opcję:");
                Console.WriteLine("1. Dodaj książkę");
                Console.WriteLine("2. Dodaj czasopismo");
                Console.WriteLine("3. Wyświetl bazę");
                Console.WriteLine("4. Zapisz bazę do pliku");
                Console.WriteLine("5. Odczytaj bazę z pliku");
                Console.WriteLine("6. Wyjście");

                int wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Podaj imię i nazwisko autora:");
                        string autor = Console.ReadLine();
                        Console.WriteLine("Podaj tytuł książki:");
                        string tytulKsiazki = Console.ReadLine();
                        Console.WriteLine("Podaj rok wydania:");
                        int rokWydania = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj nazwę wydawnictwa:");
                        string wydawnictwo = Console.ReadLine();
                        Console.WriteLine("Podaj numer ISBN:");
                        string isbn = Console.ReadLine();

                        Ksiazka ksiazka = new Ksiazka(tytulKsiazki, autor, rokWydania, wydawnictwo, isbn);
                        baza.Add(ksiazka);

                        Console.WriteLine("Książka została dodana do bazy.");
                        break;

                    case 2:
                        Console.WriteLine("Podaj tytuł czasopisma:");
                        string tytulCzasopisma = Console.ReadLine();
                        Console.WriteLine("Podaj numer:");
                        int numer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj rok wydania:");
                        int rokWydaniaCzasopisma = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj typ (kwartalnik, miesięcznik itp.):");
                        string typ = Console.ReadLine();

                        Czasopismo czasopismo = new Czasopismo(tytulCzasopisma, numer, rokWydaniaCzasopisma, typ);
                        baza.Add(czasopismo);

                        Console.WriteLine("Czasopismo zostało dodane do bazy.");
                        break;

                    case 3:
                        if (baza.Count == 0)
                        {
                            Console.WriteLine("Baza jest pusta.");
                        }
                        else
                        {
                            foreach (MaterialBiblioteczny mb in baza)
                            {
                                Console.WriteLine(mb.ToString());
                            }
                        }
                        break;

                    case 4:
                        StreamWriter sw = new StreamWriter("baza.txt");

                        foreach (MaterialBiblioteczny mb in baza)
                        {
                            sw.WriteLine(mb.ToFileLine());
                        }

                        sw.Close();
                        Console.WriteLine("Baza została zapisana do pliku.");
                        break;
                    case 5:
                        StreamReader sr = new StreamReader("baza.txt");
                        while (!sr.EndOfStream)
                        {
                            string linia = sr.ReadLine();
                            if (linia.StartsWith("Książka"))
                            {
                                string[] wartosci = linia.Split(',');
                                if (wartosci.Length == 6)
                                {
                                    Ksiazka ksiazkaStream = new Ksiazka(wartosci[1], wartosci[2], Convert.ToInt32(wartosci[3]), wartosci[4], wartosci[5]);
                                    baza.Add(ksiazkaStream);
                                }
                            }
                            else if (linia.StartsWith("Czasopismo"))
                            {
                                string[] wartosci = linia.Split(',');
                                if (wartosci.Length == 5)
                                {
                                    Czasopismo czasopismoStream = new Czasopismo(wartosci[1], Convert.ToInt32(wartosci[2]), Convert.ToInt32(wartosci[3]), wartosci[4]);
                                    baza.Add(czasopismoStream);
                                }
                            }
                        }
                        break;
                    default:
                        menu = false; 
                        break;
                }
            }
        }
    }
}