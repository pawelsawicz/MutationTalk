using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutationTalk
{
    public class SimpleIf
    {
        public int CalculateCO2Emmision(int engineSize)
        {
            if (engineSize < 4)
            {
                return 200;
            }
            else
            {
                return 400;
            }
        }
    }
}
