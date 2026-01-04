/*1. Animal Hierarchy
Description:
Create a hierarchy where Animal is the superclass, and Dog, Cat, and Bird are subclasses. Each subclass has a unique behavior.
Tasks:
Define a superclass Animal:
Add two attributes: Name (string) and Age (integer).
Add a method MakeSound() that provides a generic sound message (e.g., "Animal makes a sound").
Define subclasses Dog, Cat, and Bird:
Each subclass should override the MakeSound() method to provide its unique behavior (e.g., "Dog barks", "Cat meows", "Bird chirps").
Goal:
Learn basic inheritance, method overriding, and polymorphism by calling MakeSound() on instances of different subclasses.*/

using System;

public class Animal{
    public string Name;
    public int Age;

    public Animal(string name, int age){
        this.Name = name;
        this.Age = age;
    }

    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal{
    public Dog(string name, int age) : base(name, age){}

    public override void MakeSound(){
        Console.WriteLine("Dog barks");
    }
}
class Cat : Animal{
    public Cat(string name, int age) : base(name, age){}

    public override void MakeSound(){
        Console.WriteLine("Cat meows");
    }
}
class Bird : Animal{
    public Bird(string name, int age) : base(name, age){}

    public override void MakeSound(){
        Console.WriteLine("Bird chirps");
    }
}

public class AnimalHiearchy{
      static void Main(string[] args){
            Animal dog = new Dog("Puppy", 3);
            Animal cat = new Cat("catty", 2);
            Animal bird = new Bird("birdy", 1);
            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();
                     
  }
}