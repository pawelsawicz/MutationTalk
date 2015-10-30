using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutationTalk
{
    public class BooleanOperators
    {
        public bool IsAGreatherThanB(int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsALessThanB(int a, int b)
        {
            if (a < b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AND(bool a, bool b)
        {
            if (a && b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OR(bool a, bool b)
        {
            if (a || b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool XOR(bool a, bool b)
        {
            if (a != b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equality(bool a, bool b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
