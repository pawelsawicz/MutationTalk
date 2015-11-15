using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MutationTalk.Tests
{
    [TestFixture]
    public class GiftAidCalculatorTests
    {
        [Test]
        public void CalculateGiftAid()
        {
            //arrange
            var calculator = new GiftAidCalculator();

            //act
            var result = calculator.CalculateGiftAid(10);

            //assert
            Assert.AreEqual(2.5, result);
        }

        [Test]
        public void CalculateGiftAid_MoreThan1000_ShouldReturnGifAidEqualToDonatedAmount()
        {
            //arrange
            var calculator = new GiftAidCalculator();

            //act
            var result = calculator.CalculateGiftAid(2000);

            //assert
            Assert.AreEqual(2000, result);
        }
    }
}
