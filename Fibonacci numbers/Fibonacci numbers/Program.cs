using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
            fibonacciNum();
            Console.ReadKey();
        }

        public static void start()
        {
            Console.WriteLine("Insert Fibonacci lenght: ");
        }

        public static int insertNum()
        {
            int num;
            string input;
            input = Console.ReadLine();
            num = Convert.ToInt32(input);
            return num;
        }

        public static void fibonacciNum()
        {
            int insernum = insertNum();
            double prevnum = 0, nextnum = 1, finalnum = 0;
            for (int i=1;i <= insernum; i++)
            {
                finalnum = prevnum + nextnum;
                prevnum = nextnum;
                nextnum = finalnum;
            }
            Console.WriteLine("Your fibonacci number: " + finalnum);
        }
    }
}
