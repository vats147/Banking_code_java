using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Project_307_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,rem=0;
            int sum = 0, revsum = 0, mul = 0 ;
            Console.WriteLine("enter a number ");
            num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while (temp != 0)
            {
                rem = temp % 10;
                sum += rem;
                temp = temp / 10;
            }
            Console.WriteLine("  sum is " + sum);

            
            temp=sum;
            while (temp != 0)
            {
                rem = temp % 10;
                revsum = revsum * 10 + rem;
                temp = temp / 10;
            }
            Console.WriteLine(" reverse sum is " +revsum);
            Console.WriteLine("  sum is " + sum);

            mul = sum * revsum;
            Console.WriteLine(" multiplication  is " + mul);

            Console.ReadLine();
        }

    }

}
