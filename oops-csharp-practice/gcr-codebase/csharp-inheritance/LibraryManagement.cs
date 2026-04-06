/*Library Management with Books and Authors
Description: Model a Book system where Book is the superclass, and Author is a subclass.
Tasks:
Define a superclass Book with attributes like Title and PublicationYear.
Define a subclass Author with additional attributes like Name and Bio.
Create a method DisplayInfo() to show details of the book and its author.
Goal: Practice single inheritance by extending the base class and adding more specific details in the subclass.
*/
class Book{
    public string Title; 
    public int PublicationYear; 
    public Book(string title, int publicationYear){
        this.Title = title;
        this.PublicationYear = publicationYear;
    }
    public virtual void DisplayInfo(){
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}     
class Author : Book{
    public string Name;
    public string Bio;
    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear){
        this.Name = name;
        this.Bio = bio;
    }
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine($"Author: {Name}");
        Console.WriteLine($"Bio: {Bio}");
    }
}     
class Program{
    static void Main(string[] args){
        Author author = new Author("The Great Gatsby", 1925, "F. Scott Fitzgerald", "A novel by American author F. Scott Fitzgerald, published in 1925.");
        author.DisplayInfo();
    }
}     