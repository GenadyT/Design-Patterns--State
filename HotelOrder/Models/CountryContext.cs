using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.Models
{
    internal class CountryContext : DbContext
    {
        public CountryContext()
            : base("Hotels1")
        {
        }

        public DbSet<Country> Countries { get; set; }
    }
}
