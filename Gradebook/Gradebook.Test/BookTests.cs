using System;
using Xunit;

namespace Gradebook.Test
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStatistics()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(98.5);
            book.AddGrade(77.3);


            // Act
            var result = book.GetStatistics();


            //Assert
            Assert.Equal(88.3, result.Average, 1);
            Assert.Equal(98.5, result.Highest, 1);
            Assert.Equal(77.3, result.Lowest, 1);
            
        }
    }
}
