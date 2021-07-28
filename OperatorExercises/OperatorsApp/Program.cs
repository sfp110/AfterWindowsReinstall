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
        public static string Priority(int level)
        {
            string priorityLevel = "Code: ";
            switch (level)
            {
                case 3:
                    priorityLevel = priorityLevel + "RED";
                    break;
                case 2:
                case 1:
                    priorityLevel = priorityLevel + "AMBER";
                    break;
                case 0:
                    priorityLevel = priorityLevel + "GREEN";
                    break;
                default:
                    priorityLevel = "NOT SELECTED";
                    break;
            }

            return priorityLevel;
        }
    }
}
