/*Library Book System
Create a Book class with attributes title, author, price, and availability.
Implement a method BorrowBook() to borrow a book.
*/

using System;

public class Book{
      public string title;
      public string author;
      public double price;
      public bool availability;

      public Book(string title, string author, double price, bool availability){
        this.title = title;
        this.author = author;
        this.price = price;
        this.availability = availability;
      }

      public void BorrowBook(){
        if(this.availability == true){
          Console.WriteLine("Book is available");
        }
        else{
          Console.WriteLine("Book is not available");
        }
      }
}

public class Program{
  public static void Main(string[] args){
    Book book = new Book("The Alchemist", "Paulo Coelho",10.99, true);
    book.BorrowBook();
  }
}