//in same namespace as Program.cs
using System;
using System.Collections.Generic;

namespace GradeBook{
    //make the class public so we can use it in our unit testing project
    public class Book{
        //here is our constructor method. has to have the same name as 
        //the class, and no return type
        public Book(string name){
            grades = new List<double>();
            //take the incoming name argument and assign it to the name field
            //this.name is referiing to the name field down at teh bottom of the class
            this.name = name;
        }

        //this methods return type is Statistics, a class in the Statistics.cs file
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (double grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            return result;
        }

        public void AddGrade(double grade){
            grades.Add(grade);
        }
        //this is a field, not a variable. now any other class has access to the grades field
        //need to initialize it. do this with a constructor
        private List<double> grades;
        private string name;
    }
}