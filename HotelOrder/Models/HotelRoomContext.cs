using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.Models
{
    internal class HotelRoomContext : DbContext
    {
        public HotelRoomContext()
            : base("Hotels1")
        {
        }

        public DbSet<HotelRoom> HotelRooms { get; set; }
    }
}
