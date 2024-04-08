using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.Models
{
    internal class HotelContext : DbContext
    {
        public HotelContext()
            : base("Hotels1")
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
