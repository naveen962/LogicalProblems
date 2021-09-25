using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int temp = 0;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    temp=temp+1;
                }
            }

            if (temp == 0)
            {
                Console.WriteLine(n + "is Prime Number ");
            }
            else
            {
                Console.WriteLine(n + "is not Prime Number ");
            }
        }
    }
}
