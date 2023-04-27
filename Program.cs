using System;

namespace Static_Members_Jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            // integer methids are printed to the console.

            Console.WriteLine("Integer Methods");

            // uses the methods of the Calculate class on two numbers before printing the result as an int to the console.

            Console.WriteLine("15 + 88 is" + Calculate.Add(15, 88));
            Console.WriteLine(Calculate.Sub(78, 88));
            Console.WriteLine(Calculate.Mult(8, 9));
            Console.WriteLine(Calculate.Div(77, 8));

            // float methods are printed to the console.

            Console.WriteLine("\nFloat Methods");

            // invokes the methods of the Calculate class on two numbers, then outputs the result as a Float.

            Console.WriteLine(Calculate.Add(15.55f, 88.65f));
            Console.WriteLine(Calculate.Sub(78.45f, 88.89f));
            Console.WriteLine(Calculate.Mult(8.99f, 9.65f));
            Console.WriteLine(Calculate.Div(77.265f, 8.0f));

        }
    }
}
