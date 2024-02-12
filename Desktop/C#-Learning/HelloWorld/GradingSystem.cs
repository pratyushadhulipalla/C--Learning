using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the grading system");

            var book = new Book();
            book.addGrade(34.6);
            book.showStatistics();
        }
    }
    public class Book
    {
        List<double> grades = new List<double>() { 22.3, 44.6, 57.5 };

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }
        public double showStatistics()
        {
            var result = 0.0;
            foreach (var grade in grades)
            {
                result += grade;
            }
            result = result / grades.Count;
            Console.WriteLine(result);
            return result;
        }
    }
}
  

            
