using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Number");
            int n = int.Parse(Console.ReadLine());
            
            int rev = 0;
            while(n!= 0)
            {
                int r= n % 10; 
                n = n / 10;
                rev = rev * 10 + r;
            }
            Console.WriteLine("The Reversed no is : " + rev);


        }
        
    }
}
