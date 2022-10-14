using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event
{
    public delegate void EventManager();
    public class Events
    {
        private string _eventName;

        public static event EventManager eventlink=null;
        static int i;

        public Events(string eventName)
        {
            _eventName=eventName;
        }
        public static void HandleEvent()
        {
            i=0;
            System.Console.WriteLine("User registration");
            System.Console.WriteLine("starting the following events");
            eventlink();
        }
        public void ShowEvent()
        {
            ++i;
            System.Console.WriteLine("Event no: " +i+ "is :" +_eventName+" started");
        }

    }
}