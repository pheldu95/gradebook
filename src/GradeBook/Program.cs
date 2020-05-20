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
            var stats = book.GetStatistics();

            System.Console.WriteLine($"average: {stats.Average}, lowest: {stats.Low}, highest: {stats.High}");


        }
    }
}
