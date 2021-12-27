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
            int num = 10;
            int i;
            int j = 0;
            while (num < 1000)
            {
                j = 0;
                if (num % 2 == 1 && num % num == 0)
                {
                    i =2;
                    //Console.WriteLine("hello");
                    while(i<10)
                    {
                        if (num % i == 0)
                        {
                           // Console.WriteLine("w");
                            j++;
                        }
                        i++;
                    //    Console.WriteLine("x");
                    }
                    if (j<=0)
                    {

                        Console.WriteLine(num);
                    }
                  //  Console.WriteLine("a");

                }
                //Console.WriteLine("b");
                num++;
                //Console.WriteLine(" num is " + num);
                

            }
            Console.ReadLine();
        }

    }

}
