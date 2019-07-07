using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to displays the Day properties (year, month, day, hour, minute, second, millisecond)");

            System.DateTime currentMoment = new DateTime(2019, 6, 15, 11, 41, 50, 59);
            Console.WriteLine("year: " + currentMoment.Year);
            Console.WriteLine("month: "+ currentMoment.Month);
            Console.WriteLine("day: "+ currentMoment.Day);
            Console.WriteLine("hour: "+ currentMoment.Hour);
            Console.WriteLine("minute: "+ currentMoment.Minute);
            Console.WriteLine("second: "+ currentMoment.Second);
            Console.WriteLine("milisecond: " + currentMoment.Millisecond);

            Console.ReadKey();
        }
    }
}
