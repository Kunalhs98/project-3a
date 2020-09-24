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

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
        }
    }
}
