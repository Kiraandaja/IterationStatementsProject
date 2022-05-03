using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO - Read each comment and complete its instruction
            // like the example below

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var myNumber = 0;



            // Do While Loop:
            do
            {
                myNumber++;
                numbers.Add(myNumber);
            }
            while (myNumber < 100);


            //While Loop

            while (myNumber < 200) ;
            {
                myNumber++;
                numbers.Add(myNumber);
                Console.WriteLine("Increase:");
            }




            // Foreach loop 
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //For Loop
            for (int i = 199; i <= numbers.Count && i >= 0; i--)

            {
                Console.WriteLine($"{numbers[i]}");

                Console.WriteLine("Decrease:");
            }


            
        }
    }
}
