using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.ApiService.Models.Helpers
{
    public class GeoCoordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        
        public List<string> ReferencePoints { get; set; }

        public GeoCoordinate()
        {
            this.Latitude = 0;
            this.Longitude = 0;
        }
        public GeoCoordinate(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }


    }
}
