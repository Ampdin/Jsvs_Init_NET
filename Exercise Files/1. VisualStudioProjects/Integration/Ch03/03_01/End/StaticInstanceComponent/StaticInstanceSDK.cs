using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInstanceComponent
{
    public class StaticInstanceSDK
    {
        public int MultiplyViaInstance(int arg1, int arg2)
        {
            return arg1 * arg2;
        }

        public static int AddViaStatic(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
    }
}
