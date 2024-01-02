using System;

namespace Day6_CollectionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];//storing the numbers in array
            Console.WriteLine("Enter 10 numbers:");//getting from  the user
            //getting one -one number from the user
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            //sortting the number
            Array.Sort(numbers);

            Console.WriteLine("\nSorted Numbers in Ascending Order:");
            //spacing 
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        }
    }
}