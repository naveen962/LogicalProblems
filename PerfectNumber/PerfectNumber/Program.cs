using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number to check whether Perfectno or Not");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                } 
            }
            Console.WriteLine("sum is : " + sum);
            if (n == sum)
            {
                Console.WriteLine(n + "is a PERFECT NUMBER ");
            }

        }
    }
}
