using System;

namespace DrzewoAVL
{
    class Program
    {
        static void Main(string[] args)
        {
            Drzewo<int> drzewo = new Drzewo<int>();

            Console.WriteLine("Wstawianie liczb do drzewa...\n");
            drzewo.Wstaw(10);
            drzewo.Wstaw(20);
            drzewo.Wstaw(30);
            drzewo.Wstaw(40);
            drzewo.Wstaw(50);
            drzewo.Wstaw(25);
            drzewo.Wstaw(22);
            drzewo.Wstaw(27);

            Console.WriteLine("Wyszukiwanie w drzewie:");
            Console.WriteLine("Czy znaleziono liczbę \"30\"? {0}", drzewo.Szukaj(30));
            Console.WriteLine("Czy znaleziono liczbę \"60\"? {0}", drzewo.Szukaj(60));


            Drzewo<string> drzewo2 = new Drzewo<string>();

            Console.WriteLine("\nWstawianie ciągów do drzewa...\n");

            drzewo2.Wstaw("Hubert");
            drzewo2.Wstaw("Aleksander");
            drzewo2.Wstaw("Maciej");
            drzewo2.Wstaw("Łucja");
            drzewo2.Wstaw("Agnieszka");
            drzewo2.Wstaw("Anna");
            drzewo2.Wstaw("Leonid");
            drzewo2.Wstaw("Klara");

            Console.WriteLine("Wyszukiwanie w drzewie:");
            Console.WriteLine("Czy znaleziono ciąg \"Aleksander\"? {0}", drzewo2.Szukaj("Aleksander"));
            Console.WriteLine("Czy znaleziono ciąg \"Agata\"? {0}", drzewo2.Szukaj("Agata"));

            Console.ReadLine();
        }
    }
}