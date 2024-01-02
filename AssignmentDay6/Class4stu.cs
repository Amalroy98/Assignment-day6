using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Day6_CollectionAssignment
{


    internal class Class4stu
    {
        static void Main()
        {
            Console.WriteLine("enter the name of the student");
            ArrayList array = new ArrayList();
            array.Add("Id:1,Name:amal");
            array.Add("Id:2,Name: sajjath");
            //display
            Console.WriteLine("Student's Details :");
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}