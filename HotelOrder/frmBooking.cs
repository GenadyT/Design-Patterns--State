//using State.DL;
using System.Configuration;
using HotelOrder.Models;
using HotelOrder.StateManage;

namespace HotelOrder
{
    public partial class frmBooking : Form
    {
        private BookingManager bookingManager;
        private Color bgDisabledColor;
        private Color bgEnabledColor;        

        public frmBooking()
        {
            InitializeComponent();
            SubInit();
            FillCountries();
        }

        private void SubInit()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.bookingManager = new BookingManager();

            bookingManager.setState(bookingManager.getStartIsChosenState());
            /*OperInfo operInfo = bookingManager.CurrentState.chooseStart();
            MessageBox.Show(operInfo.OperMessage);*/

            this.bgDisabledColor = Color.FromArgb(250, 219, 175);
            this.bgEnabledColor = Color.FromArgb(220, 220, 220);            
            ButtonsEnable();
        }

        private void ButtonsEnable()
        {
            Color bgColor = this.bgEnabledColor;

            btnCountryNext.BackColor = bgColor;
            btnCityNext.BackColor = bgColor;
            btnHotelNext.BackColor = bgColor;
            btnRoomNext.BackColor = bgColor;
            btnPaymentNext.BackColor = bgColor;
            btnVoucherPrint.BackColor = bgColor;
        }

        private void ButtonsDisable()
        {
            Color bgColor = this.bgDisabledColor;

            btnCountryNext.BackColor = bgColor;
            btnCityNext.BackColor = bgColor;
            btnHotelNext.BackColor = bgColor;
            btnRoomNext.BackColor = bgColor;
            btnPaymentNext.BackColor = bgColor;
            btnVoucherPrint.BackColor = bgColor;
        }

        private void FillCountries()
        {
            using (var context = new CountryContext())
            {
                // Perform data access using the context
                List<Country> lst = context.Countries.ToList<Country>();
                cbxCountry.DataSource = lst;
            }
        }

        private void cbxCountry_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Country country = (Country)cbxCountry.SelectedValue;

            using (var context = new CityContext())
            {
                // Perform data access using the context
                List<City> citiesByCountry = context.Cities.Where(city => city.CountryId == country.Id).ToList();//.All<City>();
                cbxCity.DataSource = citiesByCountry;
            }
        }

        private void btnCountryNext_Click(object sender, EventArgs e)
        {
            string addInfo = string.Empty;

            // --- The bookingManager first entry            
            OperInfo operInfo = bookingManager.CurrentState.chooseCountry();
            if (operInfo.StateChange)
            {
                Country country = (Country)cbxCountry.SelectedValue;
                bookingManager.BookingData.setCountry(country.Name);
                addInfo = bookingManager.BookingData.ToString();
                ((Button)sender).BackColor = this.bgDisabledColor;
            }
            MessageBox.Show(Message(operInfo.OperMessage, addInfo));
            cbxCity.Select();
        }

        private void btnCityNext_Click(object sender, EventArgs e)
        {
            string addInfo = string.Empty;
            OperInfo operInfo = bookingManager.CurrentState.chooseCity();
            if (operInfo.StateChange)
            {
                City city = (City)cbxCity.SelectedValue;
                bookingManager.BookingData.setCity(city.CityName);
                addInfo = bookingManager.BookingData.ToString();
                ((Button)sender).BackColor = this.bgDisabledColor;
            }
            MessageBox.Show(Message(operInfo.OperMessage, addInfo));
            cbxHotel.Select();
        }

        private void btnHotelNext_Click(object sender, EventArgs e)
        {
            string addInfo = string.Empty;
            OperInfo operInfo = bookingManager.CurrentState.chooseCityHotel();
            if (operInfo.StateChange)
            {
                Hotel hotel = (Hotel)cbxHotel.SelectedValue;
                bookingManager.BookingData.setHotel(hotel.HotelName);
                addInfo = bookingManager.BookingData.ToString();
                ((Button)sender).BackColor = this.bgDisabledColor;
            }
            MessageBox.Show(Message(operInfo.OperMessage, addInfo));
            cbxRoom.Select();
        }

        private void btnRoomNext_Click(object sender, EventArgs e)
        {
            string addInfo = string.Empty;
            OperInfo operInfo = bookingManager.CurrentState.chooseHotelRoom();
            if (operInfo.StateChange)
            {
                HotelRoom room = (HotelRoom)cbxRoom.SelectedValue;
                bookingManager.BookingData.setRoomNumber(room.RoomNumber);
                addInfo = bookingManager.BookingData.ToString();
                ((Button)sender).BackColor = this.bgDisabledColor;
            }
            MessageBox.Show(Message(operInfo.OperMessage, addInfo));
            tbxPayment.Select();
        }

        private void btnPaymentNext_Click(object sender, EventArgs e)
        {
            string addInfo = string.Empty;
            OperInfo operInfo = bookingManager.CurrentState.makeOrderPayment();
            if (operInfo.StateChange)
            {
                double payment = Convert.ToDouble(tbxPayment.Text);
                bookingManager.BookingData.setPayment(payment);
                addInfo = bookingManager.BookingData.ToString();
                ((Button)sender).BackColor = this.bgDisabledColor;
            }
            MessageBox.Show(Message(operInfo.OperMessage, addInfo));
            btnVoucherPrint.Select();
        }

        private void btnVoucherPrint_Click(object? sender, EventArgs e)
        {
            string addInfo = string.Empty;
            OperInfo operInfo = bookingManager.CurrentState.printHotelVoucher();
            if (operInfo.StateChange)
            {
                ((Button)sender).BackColor = this.bgDisabledColor;
                addInfo = bookingManager.BookingData.ToString();
                MessageBox.Show($"Hotel Voucher::: {System.Environment.NewLine}{bookingManager.BookingData.ToString()}");
            }
            else
            {
                MessageBox.Show(operInfo.OperMessage);
            }
        }

        private void btnOrderReset_Click(object sender, EventArgs e)
        {
            bookingManager.BookingData.Reset();
            bookingManager.setState(bookingManager.getStartIsChosenState());
            cbxCountry.SelectedIndex = 0;
            tbxPayment.Text = string.Empty;
            ButtonsEnable();
            cbxCountry.Select();
        }

        private void cbxCity_SelectedIndexChanged(object? sender, EventArgs e)
        {
            City city = (City)cbxCity.SelectedValue;

            using (var context = new HotelContext())
            {
                // Perform data access using the context
                List<Hotel> hotelsByCity = context.Hotels.Where(hotel => (hotel.CountryId == city.CountryId) && (hotel.CityId == city.CityId)).ToList();
                cbxHotel.DataSource = hotelsByCity;
            }
        }

        private void cbxHotel_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Hotel hotel = (Hotel)cbxHotel.SelectedValue;

            using (var context = new HotelRoomContext())
            {
                // Perform data access using the context
                List<HotelRoom> roomsByHotel = context.HotelRooms.Where(room => (room.CountryId == hotel.CountryId) && (room.CityId == hotel.CityId) && (room.HotelId == hotel.HotelId)).ToList();
                cbxRoom.DataSource = roomsByHotel;
            }
        }

        private string Message(string operInfo, string addInfo)
        {
            string result = operInfo;

            if (addInfo.Length > 0)
            {
                result = $"{result}{System.Environment.NewLine}{addInfo}";
            }

            return result;
        }
    }
}
