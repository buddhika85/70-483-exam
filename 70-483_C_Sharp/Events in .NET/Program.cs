using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_in.NET
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
        // Event handler definition
        public EventHandler eventToFire;

        // a method to raise the event
        public void CheckBlanace(int x)
        {
            // only fire event based on a condition
            if (x > 250)
            {
                // fire event
                // "ATTENTION - " + x + " --> The balance exceeds 250......"
                eventToFire(this, EventArgs.Empty);     // object sender, EventArgs e
            }
        }
    }

    // a class that listens and handles the event
    public class EventSubscriber
    {
        // a method to handle event
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event Fired and Handling - " + "ATTENTION - " + sender + " is advising balance exceeds 250......");
        }
    }
}
