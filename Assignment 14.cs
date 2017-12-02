using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    class Program
    {
        static Stack<int> callStack = new Stack<int>();

        public static int FibonacciSeries(int n)
        {

            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
        public static void printCallStack()
        {
            Stack<int> stackToPrint = new Stack<int>();
           
            int size = callStack.Count();

            for (int i = 0; i < size; i++)
            {
                stackToPrint.Push(callStack.Pop());
            }

            for (int i = 0; i < size; i++)
            {
                callStack.Push(stackToPrint.Pop());

                Console.Write(callStack.Peek() + ", ");

            }

        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0}  ", FibonacciSeries(i));
                callStack.Push(FibonacciSeries(i));
                printCallStack();               
                Console.ReadKey();

            }
            //Console.ReadKey();
        }

    }

    
}
