using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    public class CheckLeapYear
    {
        public static void IsLeapYearOrNot()
        {
            Console.WriteLine("Please Enter a year");
            string year = Console.ReadLine();

            if(year.Length == 4)
            {
                int newyear = Convert.ToInt32(year);

                if(newyear % 4 == 0)
                {
                    Console.WriteLine(newyear + " year is leap year");
                }
                else
                {
                    Console.WriteLine(newyear + " year is not leap year");
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid year ");
            }
        }
    }
}
