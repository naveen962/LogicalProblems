using System;
using System.Collections.Generic;
using System.Text;

namespace CouponNumbers
{
    class program
    {
        public static void generateCoupon(int n)
        {
            Random random = new Random();
            int num1;
            int coupon;
            for (int i = 1; i <= n; i++)
            {
                num1 = random.Next(154, 3175);
                coupon = (1782 * num1) % 1000;
                Console.WriteLine("coupon {0}-[{1}]", i, coupon);
            }
        }
    

            static void Main(String[] args)
            {


                Console.WriteLine("Enter number to genrate n coupon");
                int num = int.Parse(Console.ReadLine());
               
                program.generateCoupon(num);
               
            }
        }
    }





