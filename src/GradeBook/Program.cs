﻿using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {

           // var p = new Program();

            Book book = new Book();
            book.AddGrade(89.1);



            List <double> grades= new List<double>() { 12.7, 10.3, 6.11,4.1 };
            grades.Add(56.1);

            var result = 0.0;
            foreach(var number in grades){
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:n1}");


            Console.ReadKey();
        }
    }
}
