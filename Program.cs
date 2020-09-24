/*
    Author: Kunal Samtani
    Due Date: 24/09/2020
    Comments: Program asks users to enter their name and then gives an output greeting them. 
*/
using System;

namespace project_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");

            try
            {
                string name = Console.ReadLine();

                greeting(name);

                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit the program and try again.");
                Console.ReadKey(true);

            }

            catch
            {
                Console.WriteLine(" ");
                Console.WriteLine("Please enter your name.");
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit the program and try again.");
                Console.ReadKey(true);
            }

            
        }
        
        private static void greeting(string name)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Hello" + name + "!");
        }

    }
}
