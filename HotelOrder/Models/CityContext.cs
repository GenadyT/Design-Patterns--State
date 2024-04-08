using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.Models
{
    internal class CityContext : DbContext
    {
        public CityContext()
            : base("Hotels1")
        {
        }

        public DbSet<City> Cities { get; set; }
    }
}
