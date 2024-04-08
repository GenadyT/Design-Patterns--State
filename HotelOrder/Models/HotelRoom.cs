using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.Models
{
    [Table("tblHotelRooms")]
    internal class HotelRoom
    {
        [Key, Column(Order = 0)]
        public int CountryId   { get; private set; }

        [Key, Column(Order = 1)]
        public int CityId  { get; private set; }

        [Key, Column(Order = 2)]
        public int HotelId { get; private set; }

        [Key, Column(Order = 3)]
        public int RoomNumber  { get; private set; }

        public bool DoubleBed  { get; private set; }

        public bool Bath   { get; private set; }
    }
}
