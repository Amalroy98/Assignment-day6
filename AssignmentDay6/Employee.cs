using System;
using System.Collections.Generic;
class Employee
{
    public string Name { get; set; }
    public string Designation { get; set; }
}
class Program
{
    static void Main()
    {
        List<Employee> employeeList = new List<Employee>();
        Console.WriteLine("Enter Employee Details. Type 'exit' to finish:");
        string input;
        do
        {
            Console.Write("Employee Name: ");
            input = Console.ReadLine();
            if (input.ToLower() != "exit")
            {
                Employee employee = new Employee();
                employee.Name = input;
                Console.Write("Designation (Program Manager, Project Manager, Team Lead, Senior Programmer, Junior Programmer): ");
                employee.Designation = Console.ReadLine();
                employeeList.Add(employee);
            }
        } while (input.ToLower() != "exit");
        // Sorting the list by Designation order
        employeeList.Sort((emp1, emp2) => GetDesignationPriority(emp1.Designation) - GetDesignationPriority(emp2.Designation));
        Console.WriteLine("Employee Details Sorted by Designation:");
        foreach (Employee employee in employeeList)
        {
            Console.WriteLine($"Name: {employee.Name}, Designation: {employee.Designation}");
        }
    }
    // Helper method to assign priority to designations
    static int GetDesignationPriority(string designation)
    {
        switch (designation.ToLower())
        {
            case "program manager":
                return 1;
            case "project manager":
                return 2;
            case "team lead":
                return 3;
            case "senior programmer":
                return 4;
            case "junior programmer":
                return 5;
            default:
                return int.MaxValue; // If designation is not recognized, assign highest priority
        }
    }
}