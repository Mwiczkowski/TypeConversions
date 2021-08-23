using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            unchecked
            {
                short number1 = 30000;
                short number2 = 30000;
                //Conversion type from int to short
                short result = (short)Add(number1, number2);
                Console.WriteLine($"{number1} + {number2} = {result}");
                NarrowingAttempt();
                ProcessBytes();
            }
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            //Converstion type from int to byte
            myByte = (byte)myInt;
            Console.WriteLine($"Value myByte: {myByte}");

        }

        static void ProcessBytes()
        {
            unchecked
            {
                byte b1 = 100;
                byte b2 = 250;
                byte sum = (byte)Add(b1, b2);
                Console.WriteLine($"sum = {sum}");
            }
        }
    }
}
