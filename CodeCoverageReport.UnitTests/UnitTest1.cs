using System;
using Xunit;

namespace CodeCoverageReport.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Greeter_Greet1()
        {
            var greeter = new Greeter();
            var result = greeter.Greet1();
            Assert.Equal("Greet1", result);
        }

        [Fact]
        public void Greeter_Greet2()
        {
            var greeter = new Greeter();
            var result = greeter.Greet2("Alberto");
            Assert.Equal("Hi Alberto", result);
        }
    }
}
