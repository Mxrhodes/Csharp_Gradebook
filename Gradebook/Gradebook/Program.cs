using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var history101Grades = new Book("Charlotte's class");
            history101Grades.AddGrade(89.1);
            history101Grades.AddGrade(98.1);
            history101Grades.AddGrade(73.1);
            history101Grades.ShowAllGrades();
            history101Grades.ShowStatistics();
            
        }
    }
}
