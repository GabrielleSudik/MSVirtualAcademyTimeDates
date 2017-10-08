using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyTimeDates
{
    class Program
    {
        static void Main(string[] args)
        {
            //stuff for current time/date:

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());

            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());

            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine();

            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(  );

            //there is no "substract". use a negative number

            Console.WriteLine(myValue.AddDays(-4).ToLongDateString());

            Console.WriteLine(myValue.Month);

            //stuff for other dates/times:

            DateTime myBirthday = new DateTime(1974, 8, 8);
            Console.WriteLine(myBirthday.ToShortDateString());

            DateTime nickyBirthday = DateTime.Parse("8/8/1977");
            Console.WriteLine(nickyBirthday);

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge);
            Console.WriteLine(myAge.TotalDays);

                Console.ReadLine();
        }
    }
}
