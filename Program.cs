using System;

namespace MethodswithLoopsandConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Threes();
        }
        //Method that will print to console all numbers 1000 through -1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);

            }

        }
        //Method that will print to the console 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3) 

            {
                Console.WriteLine(i);
            }
        }

        //Method that accepts two integers as parameters and check if they're
        //equal or not
        public static bool IsEqual(int a, int b)
        {
            if (a == b)

            {
                return true;

            }

            else
            {
                return false;
            }

        
    }

        //Method that checks if a given number is even or odd
        public static bool EvenOrOdd (int x)
        {
            if (x%2==0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }





