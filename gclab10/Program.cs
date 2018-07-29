using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab10
{
    class Program
    {
        static void Main(string[] args) 
        {
            int count = 0;
            bool y = true;
            while (y)
            {
                Console.WriteLine("Welcome to the circle tester \nEnter Radius:");
                string dataFromUser = Console.ReadLine();

                double userRadius;
                bool num1 = double.TryParse(dataFromUser, out userRadius);

                if (!num1)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
                Circle userCircle = new Circle(userRadius);

                Console.WriteLine("Circumfrence: " + userCircle.CalculateFormattedCircumfrence());
                Console.WriteLine("Area: "+ userCircle.CalculateFormattedArea());

                //Continue?
                bool invalid = true;
                while (invalid)
                {
                    Console.WriteLine("Continue? (y/n):");
                    ConsoleKeyInfo pressed = Console.ReadKey();
                    Console.WriteLine();
                    bool isY = pressed.Key == ConsoleKey.Y;
                    bool isN = pressed.Key == ConsoleKey.N;

                    invalid = !isY && !isN;
                    y = isY;
                    count++;
                }
            }
            Console.WriteLine($"Goodbye. You made {count} circle(s)");
            Console.ReadKey();
        }
    }
}
