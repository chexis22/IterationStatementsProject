using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers"
            //Collection of ints
            var numbers = new List<int>();
            //Create a variable of type int with an initializer of 0
            var i = 0;


            // Create a do-while loop

            do
            {
                //Execute this scope at least once
                i++; // Increment your variable by 1
                numbers.Add(i); // Then add your variable to "numbers"(list/collection)
            } while (i < 100); // While your variable is less than 100
                               

            // Create a while loop
            while (i < 200) // While your variable is less than 200
            {
                i++; // Increment your variable by 1
                numbers.Add(i); // Then add your variable to "numbers"(list/collection)
            }
//......................Added Numbers to collection...........................................
//......................Print those numbers in the collection below...........................

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (var num in numbers)
            {
                Console.WriteLine(num); // Write each number in your list to the console
            }
            
            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of j to 199
            // in your conditional, as long as j is less than or equal to the length of "numbers"
            // and as long as j is greater than or equal to 0
            // Decrement j by 1
            for (var j = 199; j <= numbers.Count && j >= 0; j--)
            {
                Console.WriteLine(numbers[j]); // Write to the console "numbers" at index j
            }

            Console.WriteLine(numbers.Count); //comes out as 200 when ran
        }
    }
}
