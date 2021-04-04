using System;
using Xunit;
namespace Odin.Tests

{
    public class UnitTest1
    {
        [Fact]
        public void Testcallmarina()
        {
            var Odin = new Odin_Abstractions.Odin();
            string result = Odin.callmarina();
            Console.WriteLine(result);
            Assert.Equal(result, "<h1>3</h1><br>h1>7</h1><br>Σ=10");
        }

        [Fact]
        public void Testcallguest()
        {
            var Odin = new Odin_Abstractions.Odin();
            string result = Odin.callguest();
            Console.WriteLine(result);
            Assert.Equal(result, "<h1>3</h1><br>h1>7</h1><br>");
        }
    }
}
