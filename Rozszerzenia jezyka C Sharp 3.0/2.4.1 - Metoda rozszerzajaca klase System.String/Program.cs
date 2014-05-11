using System;

namespace MetodaRozszerzajacaKlaseSystemString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kobyła ma mały bok".IsPalindrome());
            Console.WriteLine("Kobyła ma mały bok.".IsPalindrome());
            Console.WriteLine("Kob  yła   ma    ma  ł y    bok.".IsPalindrome());
            Console.WriteLine("Kobyła \n  ma   mały\tbok.".IsPalindrome());
            Console.WriteLine("Kobyła ma$małybok.".IsPalindrome());
            Console.WriteLine("Kobyła.".IsPalindrome());
        }
    }
}
