/*Car Rental System
Create a CarRental class with attributes customerName, carModel, and rentalDays.
Add constructors to initialize the rental details and calculate total cost.
*/

using System;

public class CarRental{
      public string customerName;
      public string carModel; 
      public double perDayRent;
      public int rentalDays;

      public CarRental(string customerName, string carModel, int rentalDays,double perDayRent){
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        this.perDayRent = perDayRent;
      }

      public double calculateTotalCost(){
        double totalCost = rentalDays * perDayRent;
        return totalCost;
      }
}
public class Program{
      public static void Main(string[] args){
            CarRental carRental = new CarRental("Aman","Ferrari",5,100);
            Console.WriteLine("Customer Name: "+carRental.customerName);
            Console.WriteLine("Car Model: "+carRental.carModel);
            Console.WriteLine("Number of Days Rented: "+carRental.rentalDays);
            Console.WriteLine("Rent per Day: "+carRental.perDayRent);
            double totalCost = carRental.calculateTotalCost();
            Console.WriteLine($"Total Cost for the {carRental.rentalDays} is: "+ totalCost);
      }
}