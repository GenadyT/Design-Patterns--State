using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.StateManage.States
{
    public class RoomPaymentIsMadeState : IState
    {
        private BookingManager bookingMachine;

        public RoomPaymentIsMadeState(BookingManager bookingMachine)
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
            return new OperInfo();
        }

        public OperInfo printHotelVoucher()
        {            
            bookingMachine.setState(bookingMachine.getVoucherIsPrintedState());
            return new OperInfo("You got the hotel voucher");
        }

        public OperInfo endIsChosenState()
        {
            return new OperInfo();
        }
    }
}
