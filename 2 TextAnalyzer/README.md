# README

## Opis:
Ten program w języku C# udostępnia zestaw metod rozszerzających dla klasy `string` w przestrzeni nazw `StringLibrary`. Metody te służą do obliczania różnych wystąpień w podanym ciągu znaków, w tym liczb określonych znaków, podciągów, liter, fraz, samogłosek, spółgłosek, cyfr, znaków alfanumerycznych, znaków niealfanumerycznych, białych znaków, małych liter i wielkich liter.

## Użycie:
1. **Instalacja**:
   - Sklonuj lub pobierz pliki źródłowe.
   - Upewnij się, że plik `StringLibrary.cs` jest dołączony do twojego projektu.

2. **Użycie w kodzie**:
   - Zaimportuj przestrzeń nazw `StringLibrary` w swoim programie C#: `using StringLibrary;`.
   - Wykorzystaj dostępne metody rozszerzające na obiektach typu string, jak pokazano w przykładowym kodzie w pliku `Program.cs`.

3. **Dostępne metody**:
   - `CountOccurrences(char c)`: Liczy wystąpienia określonego znaku w ciągu znaków.
   - `CountOccurrences(string substring)`: Liczy wystąpienia określonego podciągu w ciągu znaków.
   - `CountLetterOccurrences(char c, bool caseSensitive = true)`: Liczy wystąpienia określonej litery w ciągu znaków, opcjonalnie z uwzględnieniem wielkości liter.
   - `CountPhraseOccurrences(string phrase, bool caseSensitive = true)`: Liczy wystąpienia określonej frazy w ciągu znaków, opcjonalnie z uwzględnieniem wielkości liter.
   - `CountLetterOccurrences()`: Liczy wystąpienia liter w ciągu znaków.
   - `CountVowelOccurrences()`: Liczy wystąpienia samogłosek w ciągu znaków.
   - `CountConsonantOccurrences()`: Liczy wystąpienia spółgłosek w ciągu znaków.
   - `CountDigitOccurrences()`: Liczy wystąpienia cyfr w ciągu znaków.
   - `CountAlphanumericOccurrences()`: Liczy wystąpienia znaków alfanumerycznych w ciągu znaków.
   - `CountNonAlphanumericOccurrences()`: Liczy wystąpienia znaków niealfanumerycznych w ciągu znaków.
   - `CountWhitespaceOccurrences()`: Liczy wystąpienia białych znaków w ciągu znaków.
   - `CountLowercaseOccurrences()`: Liczy wystąpienia małych liter w ciągu znaków.
   - `CountUppercaseOccurrences()`: Liczy wystąpienia wielkich liter w ciągu znaków.

## Przykład:
```csharp
using StringLibrary;

class Program
{
    static void Main(string[] args)
    {
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

        // Przykładowe użycie
        Console.WriteLine($"Wystąpienia 'i': {text.CountOccurrences('i')}");
        Console.WriteLine($"Wystąpienia 'Lorem': {text.CountOccurrences("Lorem")}");
        Console.WriteLine($"Wystąpienia 'a' (bez uwzględniania wielkości liter): {text.CountLetterOccurrences('a', false)}");
        // Inne metody mogą być używane w podobny sposób...
    }
}

## Uwagi:
- Upewnij się, że plik, który czytasz, istnieje i jest dostępny podczas korzystania z tych metod.
- Te metody rozszerzające są przeznaczone do podstawowych zadań manipulacji ciągami znaków i mogą wymagać dalszych modyfikacji do konkretnych przypadków użycia lub optymalizacji wydajnościowej.

## Kompatybilność:
- Ten program jest napisany w języku C# i może być używany w dowolnym środowisku obsługującym framework .NET lub .NET Core.
- Dostarczony kod został przetestowany z użyciem .NET Core 3.1, ale powinien działać również z innymi wersjami.
