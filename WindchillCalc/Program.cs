using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindchillCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DATATYP --> namn på variabel --> värde på variabel*/
            

            double temperature;
            double speedOfwind;

            
            


            Console.WriteLine("How cold is it in celcius degrees?");


            while (!double.TryParse(Console.ReadLine(), out temperature))    
            {
                Console.WriteLine("[ERROR] input is not a double");
                Console.WriteLine("How cold is it in celcius degrees?");
            }

            Console.WriteLine("What is the speed of the wind? (In m/s)");

            while (!double.TryParse(Console.ReadLine(), out speedOfwind))
            {
                Console.WriteLine("[ERROR] input is not a double");
                Console.WriteLine("What is the speed of the wind? (In m/s)");
                Console.WriteLine(); // This is a line break, hops down a row
                    
            }

            Console.Clear(); // This cleans up the terminal from text




            Console.WriteLine($"Temperature: {temperature} degrees Celcius");
            Console.WriteLine($"Speed of wind: {speedOfwind} m/s");

            Console.WriteLine();

            Console.WriteLine("Calculation for WCT:");
            Console.WriteLine("(13.12 + 0.6215 * temperature - 11.37 * Math.Pow(speedOfwind, 0.16) + 0.3965 * temperature * Math.Pow(speedOfwind, 0.16));");
            Console.WriteLine($"(13.12 + 0.6215 * {temperature} - 11.37 * Math.Pow({speedOfwind}, 0.16) + 0.3965 * {temperature} * Math.Pow({speedOfwind}, 0.16));");

            double WCT = (13.12 + 0.6215 * temperature - 11.37 * Math.Pow(speedOfwind, 0.16) + 0.3965 * temperature * Math.Pow(speedOfwind, 0.16));
            Console.WriteLine($"Result: Wind Chill Temperature is {WCT:F1} degrees celcius"); // Limits the result to a single decimal
            








        }
    }
}
