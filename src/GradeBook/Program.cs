using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Lukes Gradebook");
            book.Addgrade(89.1);
            book.Addgrade(99.5);
            book.Addgrade(87.4);
            book.ShowStatistics();
            
            
           
        }
    }
}
