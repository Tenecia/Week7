using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsChristmasday
{
    class Program
    {
        static void Main(string[] args)// constanciate - create an instance of an object
        {
            DateTime christmas = new DateTime(2015, 12, 25); //"christmas":object,//"DateTime":class & method
            int day = christmas.Day;                         //".Day":property , "int day": variable, "christmas" : instance/object
            int month = christmas.Month;   //".Month":property 
            int year = christmas.Year;
            Console.WriteLine("Christmas day:{0}, month:{1}, year:{2}", day, month, year);
            Console.WriteLine("Day of the year:{0}", christmas.DayOfYear);
            Console.WriteLine("Is {0} leap year:{1}", year, DateTime.IsLeapYear(year));
            //Console.ReadLine(); // "ReadLine" "WriteLine" : Method, methods have parenthesis ()

            // "DateTime"(Class) is the blue print , "Christmas"(object) is the extended version of it, static are accessed directly from the class 
            // "Leap Year" (Method) , members non static 
            //".Now " (Method)static member of the "DateTime" (Class)

            String sampleLower = new String('a', 5);
            String sampleUpper = sampleLower.ToUpper();
            Console.WriteLine(sampleLower);
            Console.WriteLine(sampleUpper);
            DateTime now = DateTime.Now;
            DateTime later = now.AddHours(8);
            Console.WriteLine("Now:{0}", now);
            Console.WriteLine("8 hr later:{0}", later);
            //Console.ReadLine();

            double radius = 2.9;
            Console.WriteLine("Circle radius:{0}", radius);
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Circle area:{0}", area);
            Console.WriteLine();

            double precise = 8.7654321;
            double round3 = Math.Round(precise, 3); // variable rounded to 3 places
            double round1 = Math.Round(precise, 1); // variable rounded to 1 place 
            Console.WriteLine("Precise: {0}", precise); // writes your variable 
            Console.WriteLine("Rounded to 0.1:{0}", round1);//writes the varaible rounded to the 3rd place
            Console.WriteLine("Rounded to 0.001:{0}", round3);// wries the varaible rounded to the 1st place 
            Console.ReadLine();

        }



    }
}
