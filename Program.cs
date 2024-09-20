using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
         
            double english, math, science, mapeh, average;

            // Input the Subjet Grades
            Console.WriteLine("English:");
            english = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Math:");
            math = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Science:");
            science = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Mapeh:");
           mapeh = Convert.ToDouble(Console.ReadLine());

            average = (english + math + science + mapeh) / 4;

            Console.WriteLine("Average: " + average);

            if (average >= 98)
            {
                Console.WriteLine("With Highest Honors!");
            }
            else if (average >= 95)
            {
                Console.WriteLine(" With High Honors");
            }
            else if (average >= 90)
            {
                Console.WriteLine("With Honors");
            }

            else if (average >= 75)
            {
                Console.WriteLine("passed");
            }

            else
            {
                Console.WriteLine("Failed");
            }

            Console.ReadLine(); 
        }
    }
}