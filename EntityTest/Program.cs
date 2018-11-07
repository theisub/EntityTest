using AnotherWebTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EventContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new Event: ");
                var name = Console.ReadLine();
                List<GeoPoint>TempPoint = new List<GeoPoint> { new GeoPoint(55.003M, 26.005M)};
                var blog = new Event {EventName  = name, Points = TempPoint };
                db.Events.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.Events
                            orderby b.EventName
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.EventName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
