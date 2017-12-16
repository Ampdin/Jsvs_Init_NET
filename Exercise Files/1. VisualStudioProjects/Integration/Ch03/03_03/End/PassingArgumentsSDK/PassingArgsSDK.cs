using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArgumentsSDK
{
    // *******************************************
    // Passing Reference-Type Arguments
    // *******************************************
    public class ObjectWithProp
    {
        public string PropTextValue { get; set; }
    }
    public class ObjectUsingObjectProp
    {
        public ObjectWithProp ObjProperty { get; set; }

        public void DisplayPropValue(ObjectWithProp owp)
        {
            Console.WriteLine(owp.PropTextValue);
        }
    }

    // *******************************************
    // Passing Arguments by Reference with ref/out Keywords
    // *******************************************
    // Example A
    class RefExample
    {
        public void Method(ref int i)
        {
            i = i + 44;
        }
    }

    // Example B
    public class Item
    {
        public String ItemName { get; set; }
    }
    public class PopulateItems
    {
        public void Populate(out Item[] items)
        {
            items = new Item[5];
            for (int i = 0; i < 5; i++)
            {
                items[i] = new Item();
                items[i].ItemName = "Item" + i.ToString();
            }
        }
    }

    // *******************************************
    // Passing typeof(Type) as Method Argument 
    // *******************************************
    public class Sample
    {
        public void PassTypeArg(Type myType)
        {
            Console.Out.WriteLine(myType.ToString());
        }
    }
}
