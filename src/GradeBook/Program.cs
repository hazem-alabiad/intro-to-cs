using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book();
      book.addGrade(10.3);
      book.addGrade(36.8);
      book.addGrade(22.1);
      book.showStatistics();
    }
  }
}