using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsComponent
{
    public enum SampleEnum
    {
        ValueOne,
        ValueTwo,
        ValueThree
    }
    public class EnumDemo
    {
        public SampleEnum EnumField { get; set; }
        public void MethodA(SampleEnum value)
        {
            Console.Out.WriteLine(value);
        }
    }
}
 
