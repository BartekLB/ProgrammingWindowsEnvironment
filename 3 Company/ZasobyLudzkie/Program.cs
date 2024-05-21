using ZasobyLudzkie;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Kierownik kierownik1 = new Kierownik("Andrzej", "Kowalski", 1990, 7500, 0.1m, 500, "+48123454324", "+48123454324", "B123", "Elektryk");
            Kierownik kierownik2 = new Kierownik("Andrzej", "Kanapka", 1981, 10800, 0.1m, 700, "+48122444324", "+48122454324", "A315", "Rachunkowość");
            PracownikFizyczny pracownikFizyczny = new PracownikFizyczny("Kuba", "Nowak", 1978, 27.4m, 40, 8, kierownik1, "Mechanik");
            PracownikUmyslowy pracownikUmyslowy = new PracownikUmyslowy("Maciej", "Sosna", 1995, 5100, 0.05m, kierownik2, "+48555444333", "A102");
            CzlonekZarzadu czlonekZarzadu = new CzlonekZarzadu("Ernest", "Góra", 1992, 8900, new Osoba("Marcelina", "Dół", 1994), 7);
            Praktykant praktykant = new Praktykant("Krzysztof", "Ibisz", 2002, new Osoba("Wojciech", "Szczęsny", 1999), true);

            Console.WriteLine(kierownik1.ZwrocInformacje());
            Console.WriteLine("Wynagrodzenie: {0} \n", kierownik1.PoboryMiesieczne()) ;
            Console.WriteLine(kierownik2.ZwrocInformacje());
            Console.WriteLine("Wynagrodzenie: {0} \n", kierownik2.PoboryMiesieczne());
            Console.WriteLine(pracownikFizyczny.ZwrocInformacje());
            Console.WriteLine("Wynagrodzenie: {0} \n", pracownikFizyczny.PoboryMiesieczne());
            Console.WriteLine(pracownikUmyslowy.ZwrocInformacje());
            Console.WriteLine("Wynagrodzenie: {0} \n", pracownikUmyslowy.PoboryMiesieczne());
            Console.WriteLine(czlonekZarzadu.ZwrocInformacje());
            Console.WriteLine("Wynagrodzenie: {0} \n", czlonekZarzadu.PoboryMiesieczne());
            Console.WriteLine(praktykant.ZwrocInformacje());
            Console.WriteLine("Wynagrodzenie: {0} \n", praktykant.PoboryMiesieczne());
        }
    }
}
