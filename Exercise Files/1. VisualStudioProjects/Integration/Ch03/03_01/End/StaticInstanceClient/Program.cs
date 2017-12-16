using StaticInstanceComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInstanceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticInstanceSDK si = new StaticInstanceSDK();
            Console.WriteLine(si.MultiplyViaInstance(5,6));
            Console.WriteLine(StaticInstanceSDK.AddViaStatic(5, 6));
        }
    }
}
