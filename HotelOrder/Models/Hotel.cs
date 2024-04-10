using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.Models
{
    [Table("tblHotels")]
    internal class Hotel
    {
        [Key, Column(Order = 0)]
        public int CountryId { get; set; }
        [Key, Column(Order = 1)]
        public int CityId { get; set; }
        [Key, Column(Order = 2)]
        public int HotelId { get; set; }

        public string HotelName { get; set; }
    }
}
