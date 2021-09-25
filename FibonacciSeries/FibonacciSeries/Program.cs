using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0,b = 1;
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(a+" "+b);
            int c;
            Console.WriteLine("Fibonacci Series are");
            for(int i=1;i<=n;i++)
            {
                c = a + b;
                Console.WriteLine(" " + c);
                a = b;
                b = c;

            }
        }
    }
}
