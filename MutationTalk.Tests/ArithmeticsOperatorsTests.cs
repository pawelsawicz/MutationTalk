using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MutationTalk.Tests
{
    [TestFixture]
    public class ArithmeticsOperatorsTests
    {
        [Test]
        public void Add_TwoNumbers_ReturnValue()
        {
            var arithmeticsOperators = new ArithmeticsOperators();

            var result = arithmeticsOperators.Add(1, 2);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnValue()
        {
            var arithmeticsOperators = new ArithmeticsOperators();

            var result = arithmeticsOperators.Subtract(1, 2);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnValue()
        {
            var arithmeticsOperators = new ArithmeticsOperators();

            var result = arithmeticsOperators.Multiply(1, 2);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_TwoNumbers_ReturnValue()
        {
            var arithmeticsOperators = new ArithmeticsOperators();

            var result = arithmeticsOperators.Divide(1, 2);

            Assert.AreEqual(0.5, result);
        }
    }
}
