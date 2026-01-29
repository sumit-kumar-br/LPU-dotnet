using CalculatorService;

namespace NUnitTestProject1
{
    public class Tests
    {
        Calculator calcObj = null;
        [SetUp]
        public void Setup()
        {
            calcObj = new Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [TearDown]
        public void Reset()
        {
            calcObj = null;
        }
    }
}