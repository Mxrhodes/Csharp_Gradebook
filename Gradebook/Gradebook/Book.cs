using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowAllGrades()
        {
            foreach(double grade in grades)
            {
                Console.WriteLine($"-- {grade}");
            }
        }
        public void ShowStatistics()
        {
            double result = 0.0;
            double lowestGrade = double.MaxValue;
            double highestGrade = double.MinValue;

            foreach (double number in grades)
            {
                lowestGrade = Math.Min(number, lowestGrade);
                highestGrade = Math.Max(number, highestGrade);
                result += number;
            }
            double gradeAverage = result /= grades.Count;
            Console.WriteLine($"Lowest Grade: {lowestGrade}, Highest Grade: {highestGrade}, Average grade: {gradeAverage:N2}");

        }


    }
}
