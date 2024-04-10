using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.StateManage.States
{
    public class VoucherIsPrintedState : IState
    {
        private BookingManager bookingMachine;

        public VoucherIsPrintedState(BookingManager bookingMachine)
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
            return new OperInfo();
        }

        public OperInfo endIsChosenState()
        {   
            bookingMachine.setState(bookingMachine.getEndIsChosenState());
            return new OperInfo("The order is done");
        }
    }
}
