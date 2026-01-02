/*Hotel Booking System
Create a HotelBooking class with attributes guestName, roomType, and nights.
Use default, parameterized, and copy constructors to initialize bookings.
*/

using System;

public class HotelBooking{
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    // Default constructor
    public HotelBooking(){
        GuestName = "Aman";
        RoomType = "Standard";
        Nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights){
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking otherBooking){
        GuestName = otherBooking.GuestName;
        RoomType = otherBooking.RoomType;
        Nights = otherBooking.Nights;
    }

    public void DisplayBooking(){
        Console.WriteLine($"Guest: {GuestName}, Room Type: {RoomType}, Nights: {Nights}");
    }
}
public class Program{
      public static void Main(string[] args){
            HotelBooking defaultBooking = new HotelBooking();
            HotelBooking parameterizedBooking = new HotelBooking("Rahul", "Deluxe", 3);
            HotelBooking copyBooking = new HotelBooking(parameterizedBooking);

           defaultBooking.DisplayBooking();
           parameterizedBooking.DisplayBooking();     
           copyBooking.DisplayBooking();
      }
}