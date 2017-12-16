using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeComponent
{
    public class DisposeSDK
    {
        ~DisposeSDK()
        {
            Console.WriteLine("Displaying .NET object destructor message");
        }

        public string Name { get; set; }
    }
}
