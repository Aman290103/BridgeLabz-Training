/*Smart Home Devices
Description: Create a hierarchy for a smart home system where Device is the superclass and Thermostat is a subclass.
Tasks:
Define a superclass Device with attributes like DeviceId and Status.
Create a subclass Thermostat with additional attributes like TemperatureSetting.
Implement a method DisplayStatus() to show each device's current settings.
Goal: Understand single inheritance by adding specific attributes to a subclass, keeping the superclass general.
*/

using System;

class Device{
    public string DeviceId;
    public string Status;
    public Device(string deviceId, string status){
        this.DeviceId = deviceId;
        this.Status = status;
    }
    public virtual void DisplayStatus(){
        Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
    }
}     
class Thermostat : Device{
    public int TemperatureSetting;
    public Thermostat(string deviceId, string status, int temperatureSetting) : base(deviceId, status){
        this.TemperatureSetting = temperatureSetting;
    }
    public override void DisplayStatus(){
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}");
    }
}     
class SmartHomeDevices{
    static void Main(){
        Thermostat thermostat = new Thermostat("Thermostat1", "On", 72);
        thermostat.DisplayStatus();
    }
}
