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
            string name;
            int enno;
            DateTime dob;
            Console.WriteLine("Enter student name ");
            name = Console.ReadLine();

            Console.Write("enter your enrollment number ");
            enno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your dob(yy/mm/dd) =-");
            //dob = Console.ReadLine(Convert.ToDateTime());
                    dob= Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("your name is " + name);

            Console.WriteLine(" your enrollment number is " + enno);

            Console.WriteLine("your dob is (yy/mm/dd) =- "+dob);
            Console.ReadLine();

        }
    }
}
