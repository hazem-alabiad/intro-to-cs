using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Scott's Book");
      System.Console.WriteLine(book);
      book.addGrade(10.3);
      book.addGrade(36.8);
      book.addGrade(22.1);
      var stats = book.getStatistics();
      System.Console.WriteLine($"The lowest grade: [{stats.low}]");
      System.Console.WriteLine($"The highest grade: [{stats.high}]");
      System.Console.WriteLine($"The average grade: [{stats.average:N1}]");
    }
  }
}