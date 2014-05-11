using System;
using System.IO;
using System.Linq;

namespace LINQToObjectsJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = File.ReadLines(@"..\..\Persons.txt");
            var accounts = File.ReadLines(@"..\..\BankAccountNumbers.txt");

            var result = from line in persons
                         let tmp = line.Split(' ')
                         let person = new { Name = tmp[0], Surname = tmp[1], PESEL = tmp[2] }
                         join account in
                             (
                                 from line in accounts
                                 let tmp = line.Split(' ')
                                 select new { PESEL = tmp[0], AccountNumber = tmp[1] }
                             ) on person.PESEL equals account.PESEL
                         select new { person.Name, person.Surname, person.PESEL, account.AccountNumber };

            result.ToList().ForEach(r => Console.WriteLine("{0} {1}, PESEL: {2}, IBAN: {3}", r.Name, r.Surname, r.PESEL, r.AccountNumber));
        }
    }
}
