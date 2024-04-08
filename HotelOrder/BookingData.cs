using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder
{
    public class BookingData
    {
        public string Country { get; private set; }
        public string City { get; private set; }
        public string Hotel { get; private set; }
        public int RoomNumber { get; private set; }
        public double Payment { get; private set; }


        public BookingData() 
        { 
            Reset();
        }
        
        public void Reset()
        {
            this.Country = string.Empty;
            this.City = string.Empty;
            this.Hotel = string.Empty;
            this.RoomNumber = 0;
            this.Payment = 0.0;
        }

        public void setCountry(string country)
        {
            this.Country = country;
        }

        public void setCity(string city)
        {
            this.City = city;
        }

        public void setHotel(string hotel)
        {
            this.Hotel = hotel;
        }

        public void setRoomNumber(int roomNumber)
        {
            this.RoomNumber = roomNumber;
        }

        public void setPayment(double payment)
        {
            this.Payment = payment;
        }

        public override string ToString()
        {
            return $"Entity Data => Country: {Country}, City: {City}, Hotel: {Hotel}, Room Number: {RoomNumber}, Payment: {Payment}";
        }
    }
}
