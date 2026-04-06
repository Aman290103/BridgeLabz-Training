/*Problem 3: Vehicle Registration
Create a Vehicle class to manage vehicle details:
Instance Variables: ownerName, vehicleType.
Class Variable: registrationFee (fixed for all vehicles).
Implement the following methods:
An instance method DisplayVehicleDetails() to display owner and vehicle details.
A class method UpdateRegistrationFee() to change the registration fee.
*/

using System;

public class Vehicle{
    public string ownerName;
    public string vehicleType;
    public static double registrationFee = 100.0;

    public void DisplayVehicleDetails(){
        Console.WriteLine($"Owner Name: {ownerName}");
        Console.WriteLine($"Vehicle Type: {vehicleType}");
    }

    public static void UpdateRegistrationFee(double newFee){
        registrationFee = newFee;
    }
}
public class Program{
    public static void Main(string[] args){
        Vehicle car = new Vehicle();
        car.ownerName = "Aman";
        car.vehicleType = "Bike";

        Vehicle.UpdateRegistrationFee(150.0);

        car.DisplayVehicleDetails();
        Console.WriteLine($"Registration Fee: {Vehicle.registrationFee}");
    }
}
