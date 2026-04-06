/*3. Vehicle and Transport System

Description:
Design a vehicle hierarchy where Vehicle is the superclass, and Car, Truck, and Motorcycle are subclasses with unique attributes.
      Tasks:
	Define a superclass Vehicle:
Add two attributes: MaxSpeed (integer) and FuelType (string).
Add a method DisplayInfo() to display the vehicle's information.
Define subclasses Car, Truck, and Motorcycle that inherit from Vehicle:
Car: Add an additional attribute SeatCapacity (integer).
Truck: Add an additional attribute PayloadCapacity (integer).
Motorcycle: Add an additional attribute HasSidecar (boolean).
Demonstrate polymorphism:
Store objects of type Car, Truck, and Motorcycle in an array of Vehicle type.
Call the DisplayInfo() method on each object in the array and observe dynamic method dispatch.

Goal: Understand how inheritance helps in organizing shared and unique features across subclasses and use polymorphism for dynamic method calls.
*/

using System;

class Vehicle{
    public int MaxSpeed;
    public string FuelType; 

    public virtual void DisplayInfo(){
        Console.WriteLine($"Max Speed: {MaxSpeed}, Fuel Type: {FuelType}");
    }
}
class Car : Vehicle{
    public int SeatCapacity;

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Seat Capacity: {SeatCapacity}");
    }
}
class Truck : Vehicle{
    public int PayloadCapacity;

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Payload Capacity: {PayloadCapacity}");
    }
}
class Motorcycle : Vehicle{
    public bool HasSidecar; 
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }
}
class VehicleAndTransportSystem{
    public static void Main(string[] args){
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Car { MaxSpeed = 200, FuelType = "Gasoline", SeatCapacity = 5 };
        vehicles[1] = new Truck { MaxSpeed = 120, FuelType = "Diesel", PayloadCapacity = 5000 };
        vehicles[2] = new Motorcycle { MaxSpeed = 300, FuelType = "Petrol", HasSidecar = false };

        foreach (Vehicle vehicle in vehicles){
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
