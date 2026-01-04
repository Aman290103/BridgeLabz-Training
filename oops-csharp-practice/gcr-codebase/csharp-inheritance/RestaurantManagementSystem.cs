/* Restaurant Management System with Hybrid Inheritance
Description: Model a restaurant system where Person is the superclass and Chef and Waiter are subclasses. Both Chef and Waiter should implement a Worker interface that requires a PerformDuties() method.
Tasks:
Define a superclass Person with attributes like Name and Id.
Create an interface Worker with a method PerformDuties().
Define subclasses Chef and Waiter that inherit from Person and implement the Worker interface, each providing a unique implementation of PerformDuties().
Goal: Practice hybrid inheritance by combining inheritance and interfaces, giving multiple behaviors to the same objects.
*/

using System;

class Person{
    public string Name;
    public int Id;

    public Person(string name, int id){
        this.Name = name;
        this.Id = id;
    }
}
interface Worker{
    void PerformDuties();
}
class Chef : Person, Worker{
    public Chef(string name, int id) : base(name, id){}
    public void PerformDuties(){
        Console.WriteLine("Chef is cooking");
    }
}
class Waiter : Person, Worker{
    public Waiter(string name, int id) : base(name, id){}

    public void PerformDuties(){
        Console.WriteLine("Waiter is serving");
    }
}
class RestaurantManagementSystem{
    public static void Main(string[] args){
        Chef chef = new Chef("John", 1);
        Waiter waiter = new Waiter("Alice", 2);

        chef.PerformDuties();
        waiter.PerformDuties();
    }
}
