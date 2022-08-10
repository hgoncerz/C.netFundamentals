using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Scott's Grade book");
         
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                String input = Console.ReadLine();
                if(input == "q")
                {
                    break;
                }
                try
                {
                    double grade = Convert.ToDouble(input);
                    book.AddGrade(grade);
                }
                catch (AggregateException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
              

            }

            var stats = book.GetStatistic();

             Console.WriteLine($"The average grade is {stats.Average:n1}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            Console.ReadKey();
        }
    }
}
