using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_507_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2,temp,temp1,temp2,rem1=0,rem2=0,sum=0,sumz=0;

            Console.WriteLine("enter your first number ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your second number ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num < num2)
            {
                temp = num2;
            }
            else
            {
                temp = num;
            }
            temp1 = num;
            temp2 = num2;
            while (temp != 0)
            {

               
                    rem1 = temp1 % 10;
                    temp1 = temp1 / 10;

               

                    rem2 = temp2 % 10;
                    temp2 = temp2 / 10;
               
                sum = rem1 * rem2;
                sumz += sum;
                temp = temp / 10;

            }

            Console.WriteLine("your sum is " +sumz);


            Console.ReadLine();
           // while(
        }
    }
}
