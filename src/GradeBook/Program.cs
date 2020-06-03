using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Duncan's grade book");
            book.GradeAdded += OnGradeAdded;
            // book.AddGrade(80.2);
            // book.AddGrade(90.5);

            //allow the user to type in their own grades
            var done = false;
            while(!done){
                Console.WriteLine("Enter a grade or enter 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q"){
                    done = true;
                    continue;
                }
           
                //use try in case the user adds a bad value that causes an error
                try{
                    //turns input into a double
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }catch(ArgumentException ex){
                    Console.WriteLine(ex.Message);
                }catch(FormatException ex){
                    //catches the format exception that doubl.Parse() can throw
                    Console.WriteLine(ex.Message);
                }finally{
                    Console.WriteLine("**");
                }
                
            }

            var stats = book.GetStatistics();

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            System.Console.WriteLine($"average: {stats.Average}, lowest: {stats.Low}, highest: {stats.High}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }
        static void OnGradeAdded(object sender, EventArgs e){
            Console.WriteLine("A grade was added.");
        }
    }
}
