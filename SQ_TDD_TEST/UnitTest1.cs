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
            double exp_test_CalcArea;

            double exp_test_CalcAreaRang;

            int exp_test_CalcAngle;

            //expected

            exp_test_CalcArea = 50;

            exp_test_CalcAreaRang = 0;

            exp_test_CalcAngle = 20;

            //Act
            double act_test_CalcArea = triangle.CalcArea(10, 10);
            
            double act_test_CalcAreaRang = triangle.CalcArea(0, 10);

            int act_test_CalcAngle = triangle.CalcAngle(80,80);

            //Assert
            Assert.AreEqual(exp_test_CalcArea, act_test_CalcArea);

            Assert.AreEqual(exp_test_CalcAreaRang, act_test_CalcAreaRang);

            Assert.AreEqual(exp_test_CalcAngle, act_test_CalcAngle);


        }
    }

 
}
