using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsComponent
{
    public delegate void EventExampleHandler(object sender, string e);

    public class EventsSDK
    {
        public event EventExampleHandler SampleEvent;

        public void EventInvoke()
        {
            if (SampleEvent != null)
                SampleEvent(this, "Called from .NET!");
        }
    }
}
