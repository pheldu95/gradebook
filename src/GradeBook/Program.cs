using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Duncan's grade book");
            book.AddGrade(80.2);
            book.AddGrade(90.5);
            book.ShowStatistics();

        }
    }
}
