using PTLabTask0;

namespace PTLabTask0Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void countTest()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(3.5, calculator.add(1.5, 2.0));
            Assert.AreEqual(3, calculator.subtract(5.5, 2.5));
            Assert.AreEqual(0.5, calculator.divide(1.0, 2.0));
            Assert.AreEqual(3, calculator.multiply(1.5, 2.0));
        }
    }
}