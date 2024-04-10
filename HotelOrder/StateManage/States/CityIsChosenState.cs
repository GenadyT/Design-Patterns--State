using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.StateManage.States
{
    public class CityIsChosenState : IState
    {
        private BookingManager bookingMachine;

        //----- database operation ----------
        public int CountryId { get; private set; }
        public int CityId { get; private set; }
        //-----------------------------------

        public CityIsChosenState(BookingManager bookingMachine)
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
            return new OperInfo();
        }

        public OperInfo chooseCityHotel()
        {
            
            bookingMachine.setState(bookingMachine.getHotelIsChosenState());
            return new OperInfo("You have chosen a Hotel");
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
