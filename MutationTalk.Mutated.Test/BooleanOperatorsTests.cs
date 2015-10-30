using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MutationTalk.Mutated.Test
{
    [TestFixture]
    public class BooleanOperatorsTests
    {
        [Test]
        public void IsAGreatherThanB_WhereTwoNumbers_ReturnTrue()
        {
            var booleanOperators = new BooleanOperatorsMutated();

            var result = booleanOperators.IsAGreatherThanB(2, 1);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsALessThanB_WhereTwoNumbers_ReturnTrue()
        {
            var booleanOperators = new BooleanOperatorsMutated();

            var result = booleanOperators.IsALessThanB(1, 2);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void AND_WhereToBooleans_ReturnTrue()
        {
            var booleanOperators = new BooleanOperatorsMutated();

            var result = booleanOperators.AND(true, true);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void OR_WhereToNumbers_ReturnTrue()
        {
            var booleanOperators = new BooleanOperatorsMutated();

            var result = booleanOperators.OR(true, false);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void XOR_WhereToNumbers_ReturnTrue()
        {
            var booleanOperators = new BooleanOperatorsMutated();

            var result = booleanOperators.XOR(true, false);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void Equality_WhereToNumbers_ReturnTrue()
        {
            var booleanOperators = new BooleanOperatorsMutated();

            var result = booleanOperators.Equality(true, true);

            Assert.AreEqual(true, result);
        }
    }
}
