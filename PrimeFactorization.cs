using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    public class PrimeFactorization
    {
        public static void NPrimeFactor()
        {
            Console.WriteLine("Enter the value for prime factorization :");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i=2; i*i <N; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i);
                    N /= i;
                }
            }
            if (N > 2)
            {
                Console.WriteLine(N);
            }
        }
    }
}
