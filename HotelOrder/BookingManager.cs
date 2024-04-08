using HotelOrder.StateManage;
using HotelOrder.StateManage.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder
{
    public class BookingManager
    {
        private IState startIsChosenState;
        private IState countryIsChosenState;
        private IState cityIsChosenState;
        private IState hotelIsChosenState;
        private IState hotelRoomIsChosenState;
        private IState roomPaymentIsMadeState;
        private IState voucherIsPrintedState;
        private IState endIsChosenState;

        private IState currentState;
        public IState CurrentState
        {
            get { return currentState; }
        }

        public BookingData BookingData { get; set; }

        public BookingManager() 
        {
            this.startIsChosenState = new StartIsChosenState(this);
            this.countryIsChosenState = new CountryIsChosenState(this);
            this.cityIsChosenState = new CityIsChosenState(this);
            this.hotelIsChosenState = new HotelIsChosenState(this);
            this.hotelRoomIsChosenState = new HotelRoomIsChosenState(this);
            this.roomPaymentIsMadeState = new RoomPaymentIsMadeState(this);
            this.voucherIsPrintedState = new VoucherIsPrintedState(this);
            this.endIsChosenState = new EndIsChosenState(this);

            this.BookingData = new BookingData();
        }

        /*--------------------------------------------------------------------*/

        public OperInfo chooseStart()
        {
            return currentState.chooseStart();
        }

        public OperInfo chooseCountry()
        {
            return currentState.chooseCountry();
        }

        public OperInfo chooseCity()
        {
            return currentState.chooseCity();
        }

        public OperInfo chooseCityHotel()
        {
            return currentState.chooseCityHotel();
        }

        public OperInfo chooseHotelRoom()
        {
            return currentState.chooseHotelRoom();
        }

        public OperInfo makeOrderPayment()
        {
            return currentState.makeOrderPayment();
        }

        public OperInfo printHotelVoucher()
        {
            return currentState.printHotelVoucher();
        }

        /*--------------------------------------------------------------------*/

        public void setState(IState state)
        {
            currentState = state;
        }

        /*--------------------------------------------------------------------*/

        public IState getStartIsChosenState()
        {
            return startIsChosenState;
        }        

        public IState getCountryIsChosenState()
        {
            return countryIsChosenState;
        }

        public IState getCityIsChosenState()
        {
            return cityIsChosenState;
        }

        public IState getHotelIsChosenState()
        {
            return hotelIsChosenState;
        }

        public IState getHotelRoomIsChosenState()
        {
            return hotelRoomIsChosenState;
        }

        public IState getRoomPaymentIsMadeState()
        {
            return roomPaymentIsMadeState;
        }

        public IState getVoucherIsPrintedState()
        {
            return voucherIsPrintedState;
        }

        public IState getEndIsChosenState()
        {
            return endIsChosenState;
        }
    }
}
