using System;

namespace Day_1_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

           
            // Read and save an integer, double, and String to your variables.
            Console.WriteLine("Enter integer");
            var i2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter double");
            var d2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter string");
            var s2 = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine((i + i2).ToString("0"));
            
            // Print the sum of the double variables on a new line.
            Console.WriteLine((d + d2).ToString("0.0"));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine($"{s}{s2}");

        }
    }
}
