using TestExample;
using Xunit;

namespace Testing.Example.Test
{

    public class FactorialServicesTest
    {
        [Fact]
        public void TestFactorialZero()
        {
            FactorialServices service = new FactorialServices();
            int result = service.Calculate(0);
            Assert.Equal(1, result);
        }
        [Fact]  
        public void TestFactorialFive()
        {
            FactorialServices service = new FactorialServices();
            int result = service.Calculate(5);
            Assert.Equal(120, result);
        }

    }
}
