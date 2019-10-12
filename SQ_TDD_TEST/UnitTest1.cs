using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SQ_TDD.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcArea()
        {
            //Arrange

            var triangle = new Triangle();
            double exp_test_a;

            //expected

            exp_test_a = 50;

            //Act
            double act_test_a = triangle.CalcArea(10,10);

            //Assert
            Assert.AreEqual(exp_test_a, act_test_a);
        }
    }
}
