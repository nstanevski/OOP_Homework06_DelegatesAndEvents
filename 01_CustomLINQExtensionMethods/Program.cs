using System;
using System.Collections.Generic;

namespace _01_CustomLINQExtensionMethods
{
    class Program
    {
        static void Main()
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var filteredCollection = nums.WhereNot(x => x % 2 == 0);
            Console.WriteLine("Filtered collection: " + string.Join(", ", filteredCollection));



            var students = new List<Student>
            {
                new Student("Pesho",2),
                new Student("Gosho",3),
                new Student("Ivan",6),
            };

            Console.WriteLine("Max grade: {0}", students.Max(s => s.Grade)); 
        }
    }
}
