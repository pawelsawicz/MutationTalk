using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MutationTalk.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Add_WhereTwoNumbers_ReturnSum()
        {
            var calculator = new Calculator();

            var result = calculator.Add(1, 2);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void Substract_WhereTwoNumbers_ReturnSum()
        {
            var calculator = new Calculator();

            var result = calculator.Substract(3, 2);

            Assert.AreEqual(1, result);
        }
    }
}
