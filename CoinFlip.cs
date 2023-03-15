using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    public class CoinFlip
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("Please Enter the value for number of flips");
            int head = 0;
            int tail = 0;

            double headPercentage = 0.0;
            double tailPercentage = 0.0;

            int flip = Convert.ToInt32(Console.ReadLine());

            if (flip > 0)
            {

                 for (int i=1;i<=flip; i++)
                {
                    Random random = new Random();

                    int num = random.Next(2);

                    Console.WriteLine("Random Number generaed by system " + num);

                    if (num == 0)
                    {
                        Console.WriteLine("Its Head");
                        head++;
                    }
                    else
                    {
                        Console.WriteLine("Its Tail");
                        tail++;
                    }
                }

                Console.WriteLine("The head count is  " + head);
                Console.WriteLine("The tail count is  " + tail);

                headPercentage = (head * 100 / flip);
                tailPercentage = (tail * 100 / flip);

                Console.WriteLine("Head Percentage is " + headPercentage);
                Console.WriteLine("Tail Percentage is " + tailPercentage);
                
            }

        }
    }
}
