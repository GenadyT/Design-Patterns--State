using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.StateManage.States
{
    public class CountryIsChosenState : IState
    {
        private BookingManager bookingMachine;

        public CountryIsChosenState(BookingManager bookingMachine)
        {
            this.bookingMachine = bookingMachine;
        }

        public OperInfo chooseStart()     // called from Main function
        {
            return new OperInfo();
        }

        public OperInfo chooseCountry() 
        {
            return new OperInfo();
        }

        public OperInfo chooseCity()
        {            
            bookingMachine.setState(bookingMachine.getCityIsChosenState());
            return new OperInfo("You have chosen a City");
        }

        public OperInfo chooseCityHotel()
        {
            return new OperInfo();
        }

        public OperInfo chooseHotelRoom()
        {
            return new OperInfo();
        }

        public OperInfo makeOrderPayment()
        {
            return new OperInfo();
        }

        public OperInfo printHotelVoucher()
        {
            return new OperInfo();
        }

        public OperInfo endIsChosenState()
        {
            return new OperInfo();
        }
    }
}
