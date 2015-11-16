using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MutationTalk.Tests
{
    class SimpleIfDummyTests
    {
        [Test]
        public void CalculateCO2Emmision_EngineSize3_Return200_DummyTest()
        {
            //arrange
            var checker = new SimpleIf();

            //act
            checker.CalculateCO2Emmision(-999999999);

            //assert
            Assert.That(true);
        }

        [Test]
        public void CalculateCO2Emmision_EngineSize3_Return200_DummyTest2()
        {
            //arrange
            var checker = new SimpleIf();

            //act
            checker.CalculateCO2Emmision(99999999);

            //assert
            Assert.That(true);
        }
    }
}
