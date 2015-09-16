using Reservas.ApiService.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.ApiService.Models
{
    public class Sala
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid Owner { get; set; }

        public string OwnerName { get; set; }

        public int Rooms { get; set; }

        public string Address { get; set; }

        public GeoCoordinate Location { get; set; }
    }
}
