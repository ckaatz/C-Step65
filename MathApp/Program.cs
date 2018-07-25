using System;

namespace MathApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            string Num1 = Console.ReadLine();
            long Multiply1 = Convert.ToInt64(Num1);
            long Multiply2 = 50;
            long product = Multiply1 * Multiply2;
            Console.WriteLine(Multiply1 + " multiplied by 50 is " + product);
        }
    }
}
