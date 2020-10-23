using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Lukes Gradebook");
            book.AddGrade(95);
            book.AddGrade(90);
             
            var stats = book.GetStatistics();

            Console.WriteLine($"the lowest grade is {stats.Low}");
            Console.WriteLine($"the highest grade is {stats.High}");
            Console.WriteLine($"the average grade is {stats.Average:N1}");
            
            
           
        }
    }
}
