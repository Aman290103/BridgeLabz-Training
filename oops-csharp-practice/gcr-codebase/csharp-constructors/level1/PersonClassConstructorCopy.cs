/*Person Class (Copy Constructor)
Create a Person class with a copy constructor that clones another person's attributes.
*/

using System;

public class person{
      public string name;
      public int age;
      public string gender;

      public person(){
            name = "Aman";
            age = 23;
            gender = "Male";
      }

      public person(person other){
            name = other.name;
            age = other.age;
            gender = other.gender;
      }
}

public class Program{
      public static void Main(string[] args){
            person person1 = new person();
            person person2 = new person(person1);
            Console.WriteLine(person2.name);
            Console.WriteLine(person2.age);
            Console.WriteLine(person2.gender);
      }
}