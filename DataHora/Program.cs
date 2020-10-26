using System;
using System.Globalization;
namespace DataHora {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow; // Horario mundial GMT.

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine("=================================================");

            DateTime D1 = DateTime.Parse("2000-08-15");
            DateTime D2 = DateTime.Parse("2000 - 08 - 15 13:05:58");
            DateTime D3 = DateTime.Parse("15/08/2000");
            DateTime D4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(D1);
            Console.WriteLine(D2);
            Console.WriteLine(D3);
            Console.WriteLine(D4);
            Console.WriteLine("=================================================");

            DateTime dd1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dd2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dd1);
            Console.WriteLine(dd2);


        }
    }
}
