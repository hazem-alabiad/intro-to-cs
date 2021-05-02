using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
  class Book
  {
    // **********************************************
    // *****************   Fields    ****************    
    // **********************************************
    private List<double> grades;
    private double lowestGrade;
    private double highestGrade;
    // **********************************************
    // *****************   Methods   ****************
    // **********************************************
    public Book()
    {
      grades = new List<double>();
      lowestGrade = double.MaxValue;
      highestGrade = double.MinValue;
    }
    public void addGrade(double grade)
    {
      grades.Add(grade);
      lowestGrade = Math.Min(lowestGrade, grade);
      highestGrade = Math.Max(highestGrade, grade);
    }
    public void showStatistics()
    {
      var avg = 0.0;
      foreach (var grade in grades)
      {
        avg += grade;
      }
      avg /= grades.Count;
      System.Console.WriteLine($"The lowest grade: [{lowestGrade}]");
      System.Console.WriteLine($"The highest grade: [{highestGrade}]");
      System.Console.WriteLine($"The average grade: [{avg:N1}]");
    }
  }
}