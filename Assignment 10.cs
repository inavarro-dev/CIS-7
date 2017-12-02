using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.WriteLine("Please enter a number greater than 0.\n");
                num = Convert.ToInt32(Console.ReadLine());

                if (num <= 0)
                {
                    Console.WriteLine("invalid selection, try again.\n");
                }


            } while (num <= 0);

            Console.WriteLine("The prime factors of " + num + " are: \n\n");
            PrimeFactorizer(num);

        }
        static void PrimeFactorizer(int num)
        {
            while (num % 2 == 0)
            {
                Console.WriteLine("2\n");
                num = num / 2;
            }
            for (int i = 3; i <= Math.Sqrt(num); i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + "\n");
                    num = num / i;
                }
            }

            if (num > 2)
                Console.WriteLine(num + "\n");

        }

       
    }
}
