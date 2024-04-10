using HotelOrder.StateManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelOrder.StateManage
{
    public interface IState
    {
        OperInfo chooseStart();      // 
        OperInfo chooseCountry();      // Country Id
        OperInfo chooseCity();         // City Id
        OperInfo chooseCityHotel();    // Hotel Id
        OperInfo chooseHotelRoom();    // Room number
        OperInfo makeOrderPayment();    // Order cost    
        OperInfo printHotelVoucher();   // printed Voucher 
        OperInfo endIsChosenState();      //         
    }
}
