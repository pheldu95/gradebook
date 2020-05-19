//in same namespace as Program.cs
using System;
using System.Collections.Generic;

namespace GradeBook{
    class Book{
        //here is our constructor method. has to have the same name as 
        //the class, and no return type
        public Book(string name){
            grades = new List<double>();
            //take the incoming name argument and assign it to the name field
            //this.name is referiing to the name field down at teh bottom of the class
            this.name = name;
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;
            System.Console.WriteLine($"average: {result}, lowest: {lowGrade}, highest: {highGrade}");

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