using System;
using System.Linq;

namespace MetodaRozszerzajacaKlaseSystemString
{
    static class StringExtension
    {
        public static bool IsPalindrome(this String str)
        {
            string a = new string(str
                .Replace(" ", string.Empty)
                .ToCharArray()
                .Where(c => ! char.IsPunctuation(c) && ! char.IsWhiteSpace(c) && ! char.IsSymbol(c))
                .ToArray()
            );

            string b = new string(a.Reverse().ToArray());

            return a.Equals(b, StringComparison.OrdinalIgnoreCase);
        }
    }
}
