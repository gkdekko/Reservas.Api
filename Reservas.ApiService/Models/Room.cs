using Reservas.ApiService.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservas.ApiService.Models
{
    public class Room
    {
        public Guid Id { get; set; }

        public Categories Category { get; set; }

        public virtual Company company { get; set; }
    }
}