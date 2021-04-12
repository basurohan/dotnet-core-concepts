using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        private InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = GetBook("Book 2");

            // assert
            Assert.NotSame(book1, book2);
            Assert.False(Object.ReferenceEquals(book1, book2));
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TestCanSetNameFromReferrence()
        {
            // arrange
            InMemoryBook book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void TwoVarsCanReferrenceSameObject()
        {
            // arrange
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = book1;

            // assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 1", book2.Name);
        }

        [Fact]
        public void PassValueByReferrenceOut()
        {
            int x = 3;
            SetIntOut(out x);

            Assert.Equal(42, x);
        }

        private void SetIntOut(out int x)
        {
            x = 42;
        }

        [Fact]
        public void PassValueByReferrenceRef()
        {
            int x = 3;
            SetIntRef(ref x);

            Assert.Equal(42, x);
        }

        private void SetIntRef(ref int x)
        {
            x = 42;
        }
    }
}
