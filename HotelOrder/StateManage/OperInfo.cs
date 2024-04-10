using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOrder.StateManage
{
    public class OperInfo
    {
        public bool StateChange { get; private set; }
        public string OperMessage { get; private set; }

        public OperInfo()
        {
            this.StateChange = false;
            this.OperMessage = "No operation done";
        }

        /*public OperInfo(string operMessage, BookingData bookingData) 
        { 
            this.StateChange = true;
            this.OperMessage = $"{operMessage}{System.Environment.NewLine}{bookingData.ToString()}";
        }*/

        public OperInfo(string operMessage)
        {
            this.StateChange = true;
            this.OperMessage = $"{operMessage}";
        }
    }
}
