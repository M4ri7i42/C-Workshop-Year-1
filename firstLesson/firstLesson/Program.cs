using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int userAge = 0;
            //int userAge_next_year = 0;

            //Console.WriteLine("Please enter username: ");
            //string user = Console.ReadLine();

            //Console.WriteLine("please enter user age: ");
            //string userAge_Input = Console.ReadLine();

            //while (!int.TryParse(userAge_Input, out userAge)) // While input is not convertable keep looping || if it works, put the value into userAge
            //{
            //    Console.WriteLine($"[ERROR] {userAge_Input} is not an integer");
            //    Console.WriteLine("Please type user age again below: ");
            //    userAge_Input = Console.ReadLine();

            //}

            //userAge_next_year = userAge_next_year + userAge + 1;
            //Console.WriteLine($"Success, the user's age is {userAge}");
            //Console.WriteLine($"The user's age next year will be {userAge_next_year}");






            //_____________________________________________________________________________________________

            //int i = 1;

            //while (i < 70)
            //{
            //    i++;
            //    Console.WriteLine("Print me baby!");
            //}

            //Console.WriteLine("Process completed");



            for (int i = 0; i < 80; i++)
            {
                if ( (i % 2) == 1)
                {
                    Console.WriteLine($"Nice day ain't it?");
                }

                else
                {
                    Console.WriteLine($"Nice day, ain't it? [{i}]");
                }
            }

            Console.WriteLine("[Process completed]");


            


            


            
       

            




        }
    }
}
