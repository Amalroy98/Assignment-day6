using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day6_CollectionAssignment
{
    internal class Class1des
    {
        static void Main()
        {
            Console.WriteLine("enter the  names of the student :");
            Console.WriteLine();
            ArrayList array = new ArrayList();
            for (int i = 0; i < 5; i++) // Assuming you want to enter 5 names
            {
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                array.Add(name);
            }

            array.Sort();//default ascending
            array.Reverse();    //sorted to descending
            Console.WriteLine("Sorted array :");
            foreach (var name in array)
            {
                Console.WriteLine(name);
            }
        }
    }
}    