using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengX, lengY;
            int angleA, angleB;
            string userInput;

            var triangle = new Triangle();

            Console.Write("Input Side A length of Triangle: ");
            userInput = Console.ReadLine();
            lengX = Convert.ToInt32(userInput);
            Console.Write("Input Side B length of Triangle: ");
            userInput = Console.ReadLine();
            lengY = Convert.ToInt32(userInput);


            Console.WriteLine("Triangle Area is {0}.", triangle.CalcArea(lengX, lengY));

            Console.Write("Input Angle A Degree of Triangle: ");
            userInput = Console.ReadLine();
            angleA = Convert.ToInt32(userInput);
            Console.Write("Input Angle B Degree of Triangle: ");
            userInput = Console.ReadLine();
            angleB = Convert.ToInt32(userInput);

            Console.WriteLine("Another Angle of Triangle is {0} degree.", triangle.CalcAngle(angleA, angleB));
        }
    }
}
