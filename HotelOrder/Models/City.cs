using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.Models
{    
    [Table("tblCities")]
    internal class City
    {
        [Key, Column(Order = 0)]
        public int CountryId { get; set; }
        [Key, Column(Order = 1)]
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
