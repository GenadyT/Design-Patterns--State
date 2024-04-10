using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.StateManage.States
{
    public class HotelRoomIsChosenState : IState
    {
        private BookingManager bookingMachine;

        //----- database operation ----------
        // default room number is 777
        //-----------------------------------        

        public HotelRoomIsChosenState(BookingManager bookingMachine)
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
            return new OperInfo();
        }

        public OperInfo makeOrderPayment()
        {            
            bookingMachine.setState(bookingMachine.getRoomPaymentIsMadeState());
            return new OperInfo("You made the room payment");
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
