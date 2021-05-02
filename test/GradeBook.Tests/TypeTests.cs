using System;
using Xunit;

namespace GradeBook.Tests
{
  public class TypeTests
  {
    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
      // arrange

      // act
      var book1 = GetBook("Book 1");
      var book2 = GetBook("Book 2");

      // assert
      Assert.Equal("Book 1", book1.Name);
      Assert.Equal("Book 2", book2.Name);
      Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
      // arrange

      // act
      var book1 = GetBook("Book 1");
      var book2 = book1;

      // assert
      Assert.Same(book1, book2);
    }
    [Fact]
    public void CanSetNameFromReference()
    {
      // arrange
      var book1 = new Book("book 1");

      // act
      SetName(book1, "New Name");

      // assert
      Assert.Equal(book1.Name, "New Name");
    }

    [Fact]
    public void CSharpIsPassedByValue()
    {
      // arrange
      var book1 = new Book("Book 1");

      // act
      GetBookSetName(book1, "New Book");

      // assert
      Assert.Equal(book1.Name, "Book 1");
    }

    private Book GetBook(string name)
    {
      return new Book(name);
    }

    private void SetName(Book book, string name)
    {
      book.Name = name;
    }

    private void GetBookSetName(Book book, string name)
    {
      book = new Book(name);
    }
  }
}
