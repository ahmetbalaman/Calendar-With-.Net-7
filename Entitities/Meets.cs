using System;
using Calendar.Abstract;
using Calendar.Common;
namespace Calendar.Entitities
{
    public class Meets : Event, INotification
    {


        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
                Console.WriteLine($"Inviting: {guest}");
        }
    }
}
