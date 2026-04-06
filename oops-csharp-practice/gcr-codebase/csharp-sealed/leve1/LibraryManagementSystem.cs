/*Sample Program 2: Library Management System
Create a Book class to manage library books with the following features:
static: 
A static variable LibraryName shared across all books.
A static method DisplayLibraryName() to print the library name.
this: 
Use this to initialize Title, Author, and ISBN in the constructor.
readonly: 
Use a readonly variable ISBN to ensure the unique identifier of a book cannot be changed.
is operator: 
Verify if an object is an instance of the Book class before displaying its details.
*/

using System;

public class Book{
    public static string LibraryName;
    public string Title;
    public string Author;
    public readonly string ISBN;

    static Book(){
        LibraryName = "My Library";
    }

    public static void DisplayLibraryName(){
        Console.WriteLine($"Library Name: {LibraryName}");
    }

    public Book(string title, string author, string isbn){
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    public void DisplayBookDetails(){
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
    }

    public static bool IsBook(object obj){
        return obj is Book;
    }
}
public class Program{
    public static void Main(string[] args){
        Book.DisplayLibraryName();

        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "9780446310789");

        if(Book.IsBook(book1)){
            book1.DisplayBookDetails();
        }

        if(Book.IsBook(book2)){
            book2.DisplayBookDetails();
        }
    }
}