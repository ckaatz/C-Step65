using System;

namespace MathApp
{
    class Program
    {
        static void Main()
        {
            //Multiplication:
            Console.WriteLine("Please enter a number: ");
            string Num1 = Console.ReadLine();
            long Multiply1 = Convert.ToInt64(Num1);
            long Multiply2 = 50;
            long product = Multiply1 * Multiply2;
            Console.WriteLine(Multiply1 + " multiplied by 50 is " + product);
            //Addition:
            Console.WriteLine("Please enter another number: ");
            string Num2 = Console.ReadLine();
            int Add1 = Convert.ToInt32(Num2);
            int Add2 = 25;
            int total = Add1 + Add2;
            Console.WriteLine(Add1 + " increased by 25 is " + total);
            //Division:
            Console.WriteLine("Please enter another number: ");
            string Num3 = Console.ReadLine();
            decimal Div1 = Convert.ToDecimal(Num3);
            decimal Div2 = 12.5m;
            decimal quotient = Div1 / Div2;
            Console.WriteLine(Div1 + " divided by 12.5 is " + quotient);
            //Greater Than:
            Console.WriteLine("Please enter another number: ");
            string Num4 = Console.ReadLine();
            int Great1 = Convert.ToInt32(Num4);
            int Great2 = 50;
            if (Great1 > Great2)
                Console.WriteLine("True! " + Great1 + " is greater than 50!");
            else
                Console.WriteLine("False. " + Great1 + " is not greater than 50.");
            //Remainder:
            Console.WriteLine("Please enter a final number: ");
            string Num5 = Console.ReadLine();
            int Remain1 = Convert.ToInt32(Num5);
            int Remain2 = 7;
            int remainder = Remain1 % Remain2;
            Console.WriteLine("The remainder when dividing " + Remain1 + " by 7 is " + remainder);
            //Last Line:
            Console.ReadLine();
        }
    }
}
