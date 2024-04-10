using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelOrder.Models
{
    [Table("tblCountries")]
    internal class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        /*public Country()
        {
            this.Id = null;
            this.Name = null;
        }

        public Country(int id, string name) 
        { 
            this.Id = id;
            this.Name = name;
        }*/
    }
}
