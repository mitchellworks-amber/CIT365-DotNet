using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMitchell
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Amber Mitchell";
            string location = "Washington";
            DateTime thisDate = DateTime.Now;
            DateTime xmasDate = new DateTime(2019, 12, 25);
            TimeSpan difference = xmasDate - thisDate;
            double width, height, woodLength, glassArea;
            string widthString, heightString, end;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);

            Console.WriteLine("Today is " + thisDate.ToString("d"));
            Console.WriteLine("There are " + difference.Days + " days until next Christmas. Better get shopping!");

            // example from book
            Console.WriteLine("But first, let's make a table. Give your table a width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Give your table a height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.WriteLine("Press ENTER to end:");
            end = Console.ReadLine();
            Console.WriteLine("Goodbye!");
        }
    }
}
