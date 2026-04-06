/*Book Class
Create a Book class with attributes title, author, and price.
Provide both default and parameterized constructors.
*/

public class Book{
    public string title;
    public string author;
    public double price;

    public Book(){
        title = "c#";
        author = "Aman";
        price = 300.0;
    }

    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }
}

public class BookTest{
    public static void Main(string[] args){
        Book b1 = new Book();

        Console.WriteLine("Default Constructor");
        Console.WriteLine("Title: " + b1.title);
        Console.WriteLine("Author: " + b1.author);
        Console.WriteLine("Price: " + b1.price);

        Console.WriteLine("Parameterized Constructor");
        Book b2 = new Book("Java", "Aman", 200.0);
        Console.WriteLine("Title: " + b2.title);
        Console.WriteLine("Author: " + b2.author);
        Console.WriteLine("Price: " + b2.price);
    }
}