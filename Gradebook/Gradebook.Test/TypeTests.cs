using System;
using Xunit;

namespace Gradebook.Test
{
    public class TypeTests
    {

        [Fact] //1
        public void CanWeChangeBookName()
        {
            //Arrange
            var book1 = GetBook("Book 1");

            //Act
            SetName(book1, "New Name");

            //Assert
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]  //2
        public void GetBookReturnsDifferentObjects()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // Act
         
            //Assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

            // Confirm book1 != book2
            Assert.NotSame(book1, book2);
            
        }


        [Fact]  //3
        public void CanTwoVariablesPointToTheSameObject()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // Act

            //Assert
            Assert.Same(book1, book2);

        }

        [Fact]  //4
        public void CanweTest()
        {
            // Arrange
            var x = GetInt();

            // Act
            SetInt(ref x);

            //Assert
            Assert.Equal(42, x);
        }

        private int GetInt()
        {
            return 3;
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        Book GetBook(string name )
        {
            return new Book(name);
        }

        private void SetName(Book book, string newName)
        {
            book.Name = newName;
        }
    }
}
