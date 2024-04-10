using State.StateManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class WinnerState : IState
    {
        private BookingManager bookingMachine;

        public WinnerState(BookingManager bookingMachine) {
            this.bookingMachine = bookingMachine;
        }

        public OperInfo chooseCountry()
        {
            return new OperInfo();
        }

        public OperInfo<int> chooseCity()
        {
            return new OperInfo();
        }

        public OperInfo<int> chooseCityHotel()
        {
            return new OperInfo();
        }

        public OperInfo<int> chooseHotelRoom()
        {
            return new OperInfo();
        }

        public OperInfo<double> makeOrderPayment()
        {
            return new OperInfo();
        }

        public OperInfo<string> printHotelVoucher()
        {
            return new OperInfo();
        }
    }
}
