using System;
using Calendar.Abstract;
using Calendar.Common;
namespace Calendar.Entitities
{
    public class Todo : Event, INotification
    {

        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time To Make TODO {Title}");
        }
    }
}

