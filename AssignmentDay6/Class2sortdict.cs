using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_CollectionAssignment
{
    internal class Class2sortdict
    {
        static void Main()
        {
            Console.WriteLine("SortedDictionary of Employee Codes and Names");

            // Adding some example values to the SortedDictionary
            SortedDictionary<int, string> employeeData = new SortedDictionary<int, string>
                {
                    { 104, "John Doe" },
                    { 102, "Jane Smith" },
                    { 106, "Bob Johnson" },
                    { 101, "Alice Williams" },
                };
            Console.WriteLine("Employee Data in Sorted Order:");

            foreach (var emp in employeeData)
            {
                Console.WriteLine($"Employee Code: {emp.Key}, Employee Name: {emp.Value}");
            }

            Console.ReadLine();
        }
    }

}