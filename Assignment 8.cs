using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int selection;
            int answer;
            do
            {
                Console.WriteLine("Please enter a number greater than 0.\n");
                num = Convert.ToInt32(Console.ReadLine());

                if (num <= 0)
                {
                    Console.WriteLine("invalid selection, try again.\n");
                }


            } while (num <= 0);

            Console.WriteLine("Guess how many prime numbers there are between 0 and your number:   ");
            selection = Convert.ToInt32(Console.ReadLine());

            answer = PrimeCounter(num);

            if (selection == answer)
            {
                Console.WriteLine("You are correct, there are ");
                Console.WriteLine(answer);
                Console.WriteLine(" prime numbers between 0 and your number");
            }
            else
            {
                Console.WriteLine("You are not correct, there are ");
                Console.WriteLine(answer);
                Console.WriteLine(" prime numbers between 0 and your number");
            }


        }

        static int PrimeCounter(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("1 is not prime");
                return 0;

            }
            if (num == 2)
            {
                Console.WriteLine("2 is prime");
                return 1;
                
            }
            int count = 0;


           for(int i = 2; i < num;i++)
            {
                if (PrimeCheck(i) == true)
                {
                    count++;
                }
               
            }


            return count;

        }

        static bool PrimeCheck(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

    }
}
