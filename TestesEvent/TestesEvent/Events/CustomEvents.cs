using System;
using System.Collections.Generic;
using System.Text;

namespace TestesEvent.Events
{
    public class CustomEvents:EventArgs
    {
        public string message;
        public CustomEvents(string msg = null)
        {
            message = msg;
        }

        public delegate void DelegateCustomEvent(object sender, CustomEvents e);
        public event DelegateCustomEvent CustomEvent;
    }
}
