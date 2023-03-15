using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    public class HarmonicSum

    {
        public static void CheckSum()

        {
            
            Console.WriteLine("Enter the number for harmonic sum");
            int N = Convert.ToInt32(Console.ReadLine());

            double sum = 0.0;

            if (N == 0)
            {
                Console.WriteLine("Please enter a valid number");
            }

            else
            {
                for (int i=1; i <=N; i++)
                {
                    sum +=( 1.0 / i);
                    Console.WriteLine("The " + i + "th harmonic number is : ");
                    Console.WriteLine("1 /" + i + " = " + sum);

                }
                
            }
            
        }
    }
}
