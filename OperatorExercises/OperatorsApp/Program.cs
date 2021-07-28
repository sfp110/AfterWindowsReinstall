using System;

namespace OperatorsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOdd(22));
        }

        public static bool EvenOdd(int number)
        {
            //returns true if the result = 0
            //else is not even
            return number % 2 == 0;
        }
    }
}
