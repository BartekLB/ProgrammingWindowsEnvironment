using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public static class StringExtensions
    {
        public static int CountOccurrences(this string str, char c)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (ch == c)
                {
                    count++;
                }
            }
            return count;
        }
        public static int CountOccurrences(this string str, string substring)
        {
            int count = 0;
            int index = 0;
            while ((index = str.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }
            return count;
        }

        public static int CountLetterOccurrences(this string str, char c, bool caseSensitive = true)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (caseSensitive && ch == c || !caseSensitive && char.ToLower(ch) == char.ToLower(c))
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountPhraseOccurrences(this string str, string phrase, bool caseSensitive = true)
        {
            int count = 0;
            int index = 0;
            StringComparison comparison = caseSensitive ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
            while ((index = str.IndexOf(phrase, index, comparison)) != -1)
            {
                count++;
                index += phrase.Length;
            }
            return count;
        }

        public static int CountLetterOccurrences(this string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountVowelOccurrences(this string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (char.IsLetter(ch) && "aeiouAEIOU".IndexOf(ch) != -1)
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountConsonantOccurrences(this string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (char.IsLetter(ch) && "aeiouAEIOU".IndexOf(ch) == -1)
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountDigitOccurrences(this string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountAlphanumericOccurrences(this string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountNonAlphanumericOccurrences(this string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountWhitespaceOccurrences(this string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (char.IsWhiteSpace(ch))
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountLowercaseOccurrences(this string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    count++;
                }
            }
            return count;
        }
        public static int CountUppercaseOccurrences(this string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
