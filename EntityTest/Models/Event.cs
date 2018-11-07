using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherWebTest.Models
{
    public class Event
    {
       

        public int EventId { get; set; }
        public int AdminId { get; set; }

        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime? EventStartTime { get; set; }
        public DateTime? EventEndTime { get; set; }
        public string EventUrl { get; set; }

        public virtual List<GeoPoint> Points { get; set; }


        

    }
}
