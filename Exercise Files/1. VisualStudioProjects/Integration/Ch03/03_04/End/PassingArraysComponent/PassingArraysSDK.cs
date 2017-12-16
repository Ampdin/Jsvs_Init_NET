using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArraysComponent
{
    public class ObjectItem
    {
        public ObjectItem(string name)
        {
            ObjectItemName = name;
        }

        public string ObjectItemName { get; set; }
    }

    public class Class1
    {
        public string[] GetItems()
        {
            Console.Out.WriteLine("*** Retrieving array of strings ***\n");
            return new string[] { "item1", "item2", "item3" };
        }

        public ObjectItem[] GetRefItems()
        {
            Console.Out.WriteLine("\n*** Retrieving array of .NET objects ***\n");
            return new[] { new ObjectItem("ObjectItem1"), new ObjectItem("ObjectItem2"), new ObjectItem("ObjectItem3") };
        }

        public void DisplayArray(string[] items)
        {
            Console.Out.WriteLine("\n*** Displaying value-typed array ***\n");
            foreach (var item in items)
                Console.Out.WriteLine(item);
        }

        public void DisplayArray(ObjectItem[] items)
        {
            Console.Out.WriteLine("\n*** Displaying ref-typed array ***\n");
            foreach (var item in items)
                Console.Out.WriteLine(item.ObjectItemName);
        }
    }
}
