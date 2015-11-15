using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MutationTalk.Tests
{
    [TestFixture]
    public class SimpleIfTests
    {
        [Test]
        public void CalculateCO2Emmision_EngineSize3_Return200_Basic()
        {
            //arrange
            var checker = new SimpleIf();

            //act
            var result = checker.CalculateCO2Emmision(3);

            //assert
            Assert.AreEqual(200, result);
        }

        #region

        [Test]
        [TestCase(3, 200)]
        [TestCase(4, 400)]
        public void CalculateCO2Emmision_EngineSize3_Return200_BetterOne(int input, int expectedOutput)
        {
            //arrange
            var checker = new SimpleIf();

            //act
            var result = checker.CalculateCO2Emmision(input);

            //assert
            Assert.AreEqual(expectedOutput, result);
        }

        #region

        [Test]
        [TestCase(3, 200)]
        [TestCase(4, 400)]
        [TestCase(5, 400)]
        public void CalculateCO2Emmision_EngineSize3_Return200_BestOne(int input, int expectedOutput)
        {
            //arrange
            var checker = new SimpleIf();

            //act
            var result = checker.CalculateCO2Emmision(input);

            //assert
            Assert.AreEqual(expectedOutput, result);
        }

        #endregion

        #endregion
    }
}
