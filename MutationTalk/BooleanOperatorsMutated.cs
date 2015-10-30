using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutationTalk
{
    public class BooleanOperatorsMutated
    {
        public bool IsAGreatherThanB(int a, int b)
        {
            return a <= b;
        }
        public bool IsALessThanB(int a, int b)
        {
            return a >= b;
        }
        public bool AND(bool a, bool b)
        {
            return a || !b;
        }
        public bool OR(bool a, bool b)
        {
            return a && !b;
        }
        public bool XOR(bool a, bool b)
        {
            return a == b;
        }
        public bool Equality(bool a, bool b)
        {
            return a != b;
        }
    }
}
