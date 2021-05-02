using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
  public class Book
  {
    // **********************************************
    // *****************   Methods   ****************
    // **********************************************
    public Book(string name)
    {
      grades = new List<double>();

      Name = name;
    }
    public void addGrade(double grade)
    {
      grades.Add(grade);
    }
    public Statistics getStatistics()
    {
      var result = new Statistics();
      result.low = double.MaxValue;
      result.high = double.MinValue;
      result.average = 0.0;
      foreach (var grade in grades)
      {
        result.average += grade;
        result.low = Math.Min(result.low, grade);
        result.high = Math.Max(result.high, grade);
      }
      result.average /= grades.Count;
      result.average = Math.Round(result.average, 1);
      return result;
    }

    // **********************************************
    // *****************   Fields    ****************    
    // **********************************************
    private List<double> grades;
    public string Name;
  }
}