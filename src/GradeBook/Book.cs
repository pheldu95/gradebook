//in same namespace as Program.cs
using System;
using System.Collections.Generic;

namespace GradeBook{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    
    //make the class public so we can use it in our unit testing project
    public class Book{
        //here is our constructor method. has to have the same name as 
        //the class, and no return type
        public Book(string name){
            grades = new List<double>();
            //take the incoming name argument and assign it to the name field
            //this.name is referiing to the name field down at teh bottom of the class
            this.Name = name;
        }

        //this methods return type is Statistics, a class in the Statistics.cs file
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            //a different way to loop
            // var index = 0;
            // while(index < grades.Count){
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.Average += grades[index];
            //     index++;
            // }
            
            foreach (double grade in grades)
            {
                // if(grade == 42.1){
                //     //break out of the loop early
                //     // break;
                //     //skip the rest of the code in the loop, but contionue looping
                //     continue;
                // }
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            switch(result.Average){
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }
            return result;
        }
        //method for if they pass in a letter grade instead of a number
        public void AddGrade(char letter){
            switch(letter){
                case 'A':
                    AddGrade(90);
                    //break out of the switch
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }
        public void AddGrade(double grade){
            if(grade <= 100 && grade >= 0){
                grades.Add(grade);
                if(GradeAdded != null){
                    //invoke the delegate
                    GradeAdded(this, new EventArgs());
                }
            }else{
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        //field for the delegate. has a grade added event
        public event GradeAddedDelegate GradeAdded;

        //this is a field, not a variable. now any other class has access to the grades field
        //need to initialize it. do this with a constructor
        private List<double> grades;
        

        //this is a property that can be read by the program.
        //so the user can see the name of the book but the book is still private
        public string Name{
           get; 
           //private makes it so the name cannot be changed after 
            //making the book. this is a read only property
           set;
        }

        // //a readonly can only be assigned in a constructor. can't change it in a different method 
        // readonly string category = "Science";

        //const even more strict. can never be changed. not a variable
        //developers often make them capitalized
        public const string CATEGORY = "Science";
    }
}