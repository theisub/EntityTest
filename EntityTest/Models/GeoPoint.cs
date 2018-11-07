using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherWebTest.Models
{
    public class GeoPoint
    {
        [Key]
        public int PointId { get; set; }
        public int EventId { get; set; }
        public decimal PointLatitiude { get; set; }
        public decimal PointLongitude { get; set; }


        //public virtual GeoPoint GetPoint { get; set; }
        public GeoPoint(decimal Lat, decimal Long)
        {
            PointLatitiude = Lat;
            PointLongitude = Long;
        }
        //Флаг места встречи?
    }
}
