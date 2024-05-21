using StringLibrary;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "example.txt";
            string text = File.ReadAllText(filename);

            Console.WriteLine($"Liczba wystąpień litery 'c': {text.CountOccurrences('c')}");
            Console.WriteLine($"Liczba wystąpień ciągu 'Lorem': {text.CountOccurrences("Lorem")}");
            Console.WriteLine($"Liczba wystąpień litery 'a' (bez względu na wielkość): {text.CountLetterOccurrences('a', false)}");
            Console.WriteLine($"Liczba wystąpień frazy 'ipsum dolor' (bez względu na wielkość liter): {text.CountPhraseOccurrences("ipsum dolor", false)}");
            Console.WriteLine($"Liczba wystąpień samogłosek: {text.CountVowelOccurrences()}");
            Console.WriteLine($"Liczba wystąpień spółgłosek: {text.CountConsonantOccurrences()}");
            Console.WriteLine($"Liczba wystąpień cyfr: {text.CountDigitOccurrences()}");
            Console.WriteLine($"Liczba wystąpień znaków alfanumerycznych: {text.CountAlphanumericOccurrences()}");
            Console.WriteLine($"Liczba wystąpień znaków niealfanumerycznych: {text.CountNonAlphanumericOccurrences()}");
            Console.WriteLine($"Liczba wystąpień białych znaków: {text.CountWhitespaceOccurrences()}");
            Console.WriteLine($"Liczba wystąpień małych liter: {text.CountLowercaseOccurrences()}");
            Console.WriteLine($"Liczba wystąpień wielkich liter: {text.CountUppercaseOccurrences()}");
        }
    }
}
