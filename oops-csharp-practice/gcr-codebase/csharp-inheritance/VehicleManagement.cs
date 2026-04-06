/* Vehicle Management System with Hybrid Inheritance
Description: Model a vehicle system where Vehicle is the superclass and ElectricVehicle and PetrolVehicle are subclasses. Additionally, create a Refuelable interface implemented by PetrolVehicle.
Tasks:
Define a superclass Vehicle with attributes like MaxSpeed and Model.
Create an interface Refuelable with a method Refuel().
Define subclasses ElectricVehicle and PetrolVehicle. PetrolVehicle should implement Refuelable, while ElectricVehicle include a Charge() method.
Goal: Use hybrid inheritance by having PetrolVehicle implement both Vehicle and Refuelable, demonstrating how Java interfaces allow adding multiple behaviors.
*/

using System;

class Vehicle{
    public int MaxSpeed;
    public string Model;
}
interface Refuelable{
    void Refuel();
}
class ElectricVehicle : Vehicle{
    public void Charge(){
        Console.WriteLine("Charging electric vehicle");
    }
}
class PetrolVehicle : Vehicle, Refuelable{
    public void Refuel(){
        Console.WriteLine("Refueling petrol vehicle");
    }
}
class Program{
    public static void Main(){
        ElectricVehicle electricVehicle = new ElectricVehicle();
        electricVehicle.MaxSpeed = 100;
        electricVehicle.Model = "Tesla";
        electricVehicle.Charge();

        PetrolVehicle petrolVehicle = new PetrolVehicle();
        petrolVehicle.MaxSpeed = 120;
        petrolVehicle.Model = "Toyota";
        petrolVehicle.Refuel();
    }
}
