using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            // event publisher instance
            EventPublisher epublisher = new EventPublisher();

            // event subscriber/handler instance
            EventSubscriber esubscriber = new EventSubscriber();

            // attach the event handler to the event via delegates
            // when event fired it is handled via HandleEvent()
            epublisher.eventToFire += esubscriber.HandleEvent;

            // Testing
            epublisher.CheckBlanace(249);
            System.Threading.Thread.Sleep(6000);    // sleep for 6 seconds

            epublisher.CheckBlanace(250);
            System.Threading.Thread.Sleep(6000);

            epublisher.CheckBlanace(251);
            System.Threading.Thread.Sleep(6000);

            epublisher.CheckBlanace(160);
            System.Threading.Thread.Sleep(6000);

            epublisher.CheckBlanace(357);
            System.Threading.Thread.Sleep(6000);
        }
    }

    // a class that fires the event
    public class EventPublisher
    {
        // create a delegate
        public delegate void del(string message);

        // create an event of the delegate type
        // This event requires to be handled by a delegate on its type
        public event del eventToFire;

        // a method to raise the event
        public void CheckBlanace(int x)
        {
            // only fire event based on a condition
            if (x > 250)
            {
                // fire event
                eventToFire("ATTENTION - " + x + " --> The balance exceeds 250......");
            }
        }
    }

    // a class that listens and handles the event
    public class EventSubscriber
    {
        // a method to handle event
        public void HandleEvent(string msg)
        {
            Console.WriteLine("Event Fired and Handling - " + msg);
        }
    }
}
