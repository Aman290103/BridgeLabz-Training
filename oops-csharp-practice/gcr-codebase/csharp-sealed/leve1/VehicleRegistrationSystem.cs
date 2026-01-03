/*Sample Program 6: Vehicle Registration System
Create a Vehicle class with the following features:
static: 
A static variable RegistrationFee common for all vehicles.
A static method UpdateRegistrationFee() to modify the fee.
this: 
Use this to initialize OwnerName, VehicleType, and RegistrationNumber in the constructor.
readonly: 
Use a readonly variable RegistrationNumber to uniquely identify each vehicle.
is operator: 
Check if an object belongs to the Vehicle class before displaying its registration details.
*/

using System;

public class Vehicle{
    public static double RegistrationFee = 100.0;
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }
    public readonly string RegistrationNumber;

    public Vehicle(string ownerName, string vehicleType, string registrationNumber){
        OwnerName = ownerName;
        VehicleType = vehicleType;
        RegistrationNumber = registrationNumber;
    }

    public static void UpdateRegistrationFee(double newFee){
        RegistrationFee = newFee;
    }

    public void DisplayRegistrationDetails(){
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Vehicle Type: {VehicleType}");
        Console.WriteLine($"Registration Number: {RegistrationNumber}");
        Console.WriteLine($"Registration Fee: {RegistrationFee}");
    }
}
public class Program{
    public static void Main(string[] args){
        Vehicle car = new Vehicle("John Doe", "Car", "ABC123");
        Vehicle.UpdateRegistrationFee(150.0);
        car.DisplayRegistrationDetails();
        Console.WriteLine($"Is car an instance of Vehicle? {car is Vehicle}");
    }
}