/*Problem 2: Book Library System
Design a Book class with:
ISBN (public)
title (protected)
author (private)
Implement methods to:
Set and get the author name.
Create a subclass EBook to access ISBN and title and demonstrate access modifiers.
*/

using System;

public class Book{
    public string ISBN { get; set; }
    protected string Title { get; set; }
    private string Author { get; set; }

    public Book(string ISBN, string title, string author){
        this.ISBN = ISBN;
        this.Title = title;
        this.Author = author;
    }

    public void SetAuthor(string author){
        Author = author;
    }

    public string GetAuthor(){
        return Author;
    }
}

public class Ebook : Book{
    public Ebook(string ISBN, string title, string author)
        : base(ISBN, title, author)
    {
    }

    // Renamed method
    public void DisplayBookInfo(){
        Console.WriteLine("ISBN: " + ISBN);     // public
        Console.WriteLine("Title: " + Title);   // protected
    }
}

public class BookLibrarySystem{
    public static void Main(string[] args){
        Book book = new Book("978-0123456789", "C# Programming", "Aman");
        Console.WriteLine("Author: " + book.GetAuthor());

        book.SetAuthor("xyz");
        Console.WriteLine("Updated Author: " + book.GetAuthor());

        Ebook ebook = new Ebook("978-0201616224", "Half Girlfriend", "Chetan Bhagat");
        ebook.DisplayBookInfo();
    }
}
