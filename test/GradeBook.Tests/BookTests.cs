using System;
using Xunit;

namespace GradeBook.Tests
{
  public class BookTests
  {
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
      // arrange
      var book = new Book("Hazem's Book");
      book.addGrade(10.3);
      book.addGrade(36.8);
      book.addGrade(22.1);

      // act
      var result = book.getStatistics();

      // assert
      Assert.Equal(10.3, result.low);
      Assert.Equal(36.8, result.high);
      Assert.Equal(23.1, result.average);
    }
  }
}
