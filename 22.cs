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
            int number;
            Console.WriteLine(" Enter a number ");
            number = Convert.ToInt32(Console.ReadLine());

            int temp = number,rem;
            int Totalodd = Toaleven = 0;
            int oddsum = evensum = 0;
            while (temp != 0)
            {

                rem = temp % 10;

                if (rem % 2 == 0)
                {
                    Totaleven++;
                    evensum += rem;
                }
                else
                {
                    Totalodd++;
                    oddsum += rem;
                }

                temp = temp / 10;


            }
            Console.WriteLine(" Total number of odd is  " + Totalodd);
            Console.WriteLine(" Total number of even is  " + Totaleven);
            Console.WriteLine(" Total sum of odd number is  " + oddsum);
            Console.WriteLine(" Total sum of even number is  " + evensum);
         
        }

	}

}
