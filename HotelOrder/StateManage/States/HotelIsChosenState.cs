using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrder.StateManage;

namespace HotelOrder.StateManage.States
{
    public class HotelIsChosenState : IState
    {
        private BookingManager bookingMachine;        

        public HotelIsChosenState(BookingManager bookingMachine)
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
            return new OperInfo();
        }

        public OperInfo chooseHotelRoom()
        {            
            bookingMachine.setState(bookingMachine.getHotelRoomIsChosenState());
            return new OperInfo("You have chosen a Hotel Room");
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
