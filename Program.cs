using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";
            while (cont.ToLower().Equals("y"))
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Please enter the room length: ");
                string userNum1 = Console.ReadLine();
                double num = double.Parse(userNum1);

                Console.WriteLine("Please enter the room width: ");
                string userNum2 = Console.ReadLine();
                double num2 = double.Parse(userNum2);
                Console.WriteLine("Area: " + (num * num2));
                Console.WriteLine("Perimeter: " + (2* (num + num2)));

                Console.WriteLine("Would you like to calculate the volume of the room? (y/n): ");
                string volCalc = Console.ReadLine();

                if (volCalc.ToLower().Equals("y")) {
                    Console.WriteLine("Please enter the room height: ");
                    string vol = Console.ReadLine();
                    double userVol = double.Parse(vol);
                    Console.WriteLine("Volume: " + (num * num2 * userVol));
                }


                Console.WriteLine("Would you like to continue? (y/n)") ;
                cont = Console.ReadLine();
                
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
