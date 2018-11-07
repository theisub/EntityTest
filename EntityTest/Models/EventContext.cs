using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherWebTest.Models
{
    public class EventContext : DbContext
    {
        //public DbSet<User> Users { get; set; } //Это надо?
        public DbSet<GeoPoint> GeoPoints { get; set; } //И это тоже
        public DbSet<Event> Events { get; set; }
        

    }
}
