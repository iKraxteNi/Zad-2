using System;
using Xunit;
using Zad_2;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var Book = new Book("Hobit", 20);
            var expectet = 20;
            var price = Book.getPrice();
            Assert.Equal(expectet, price);


        }
    }
}
