using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            // arrange
            InMemoryBook book = new InMemoryBook("Test Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            Statistics stats = book.GetStats();

            // assert
            Assert.Equal("Test Book", book.getName());
            Assert.Equal(85.6, stats.Average, 1);
            Assert.Equal(90.5, stats.High, 1);
            Assert.Equal(77.3, stats.Low, 1);
            Assert.Equal('B', stats.Letter);
        }
    }
}
