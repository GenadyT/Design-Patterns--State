## State Design Pattern

This .Net C# project demonstrates "State" design pattern and is inspired by the book -   
	-------------------------------------------------------------------  
	Freeman, Eric; Robson, Elisabeth; Bates, Bert; Sierra, Kathy.   
	Head First Design Patterns: A Brain-Friendly Guide. O'Reilly Media.  
	-------------------------------------------------------------------

### Pattern Definition

The State Pattern allows an object to alter its behavior when its internal state changes. 

### Project Topic

The consept is taken from the book.
The project theme is a hotel room booking.
Booking a hotel room is a 6-step process: selecting a country, selecting a city, 
selecting a city hotel, selecting a hotel room, arranging payment, and printing a hotel voucher.

### "HotelOrder" Project main classes

The booking main "states":
CountryIsChosenState, CityIsChosenState, HotelIsChosenState, HotelRoomIsChosenState,
RoomPaymentIsMadeState, and VoucherIsPrintedState classes.
The "Context" object is BookingManager class.

### Additional Info

1. The project has a room order form intuitive WinForm user interface.
2. Database bak file - Hotels1.bak file.
3. Pattern diagram - pattern-diagram.jpg file. 

