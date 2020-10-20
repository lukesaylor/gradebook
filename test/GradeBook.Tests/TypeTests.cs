using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

        }
        Book  GetBook(string name)
        {
            return new Book(name);
        }
    }
}
