using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Scott's Grade book"); 
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistic();

             Console.WriteLine($"The average grade is {stats.Average:n1}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Low}");
            Console.ReadKey();
        }
    }
}
