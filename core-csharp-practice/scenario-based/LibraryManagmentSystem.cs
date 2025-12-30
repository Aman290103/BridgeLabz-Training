/*Library Management System – Book Search and Checkout
Scenario: You’re designing a system for a small library to manage books and track checkouts.
Problem Requirements:
● Store book details (title, author, status) in a 3d Array.
● Allow searching by partial title using String operations.
● Store book data in an Array.
● Use methods for searching, displaying, and updating book status (checked out or
available).*/

using System;

public class LibraryManagementSystem{
      static int maxBooks;
      static int bookCount;
      static string[,] books;

    // ----------------store books details----------------//
    public static void manageLibrary(){
        Console.Write("Enter maximum number of books: ");
        maxBooks = Convert.ToInt32(Console.ReadLine());

        books = new string[maxBooks, 3];

        Console.Write("Enter number of initial books: ");
        bookCount = Convert.ToInt32(Console.ReadLine());

        if (bookCount > maxBooks){
            Console.WriteLine("Initial book count exceeds maximum capacity.");
            bookCount = 0;
            return;
        }

        for(int i = 0; i < bookCount; i++){
            Console.WriteLine($"\nEnter details for Book {i + 1}:");
            Console.Write("Title: ");
            books[i, 0] = Console.ReadLine();

            Console.Write("Author: ");
            books[i, 1] = Console.ReadLine();

            books[i, 2] = "Available";
        }
    }
//---------------------Display Books method----------------------//
    public static void displayBooks(){
        Console.WriteLine("\n--- BOOK LIST ---");
        for (int i = 0; i < bookCount; i++){
            Console.WriteLine(
                $"Title: {books[i, 0]}, Author: {books[i, 1]}, Status: {books[i, 2]}"
            );
        }
    }

//----------------------------Book Searching Method---------------------//
    static void searchBook(string text){
        bool found = false;
        for (int i = 0; i < bookCount; i++){
            if (books[i, 0].ToLower().Contains(text.ToLower()))
            {
                Console.WriteLine(
                    $"Title: {books[i, 0]}, Author: {books[i, 1]}, Status: {books[i, 2]}"
                );
                found = true;
            }
        }
        if (!found)
            Console.WriteLine("Book not found.");
    }

//--------------------------Book status method---------------------------------//
    public static void bookStatus(string title){
        for (int i = 0; i < bookCount; i++){
            if (books[i, 0].Equals(title, StringComparison.OrdinalIgnoreCase)){
                if (books[i, 2] == "Available"){
                    books[i, 2] = "Checked Out";
                    Console.WriteLine("Book checked out successfully.");
                }
                else
                {
                    Console.WriteLine("Book already checked out.");
                }
                return;
            }
        }
    }
 //-----------------------Add books method-------------------------//
    public static void addBook(){
        if (bookCount >= maxBooks){
            Console.WriteLine("Library full.");
            return;
        }

        Console.Write("Enter title: ");
        books[bookCount, 0] = Console.ReadLine();

        Console.Write("Enter author: ");
        books[bookCount, 1] = Console.ReadLine();

        books[bookCount, 2] = "Available";
        bookCount++;

        Console.WriteLine("Book added successfully.");
    }

//-------------------------- update book status method---------------------//
    public static void updateBookStatus(){
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        for (int i = 0; i < bookCount; i++){
            if (books[i, 0].Equals(title, StringComparison.OrdinalIgnoreCase)){
                Console.Write("Enter new status (Available / Checked Out): ");
                books[i, 2] = Console.ReadLine();
                Console.WriteLine("Status updated.");
                return;
            }
        }
}

//------------------------Main method-----------------------//
     public static void Main(){
        while (true){
            Console.WriteLine("\n=== LIBRARY MANAGEMENT SYSTEM ===");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");
            Console.Write("Choose Role: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1: AdminMenu(); break;
                case 2: UserMenu();break;
                case 3: return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

     // ---------------- ADMIN MENU ----------------
   public static void AdminMenu(){
        while (true){
            Console.WriteLine("\n--- ADMIN MENU ---");
            Console.WriteLine("1. Manage Library");
            Console.WriteLine("2. Display Books");
            Console.WriteLine("3. Add Book");
            Console.WriteLine("4. Update Book Status");
            Console.WriteLine("5. Back");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice){
                case 1: manageLibrary(); break;
                case 2: displayBooks(); break;
                case 3: addBook(); break;
                case 4: updateBookStatus(); break;
                case 5: return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
    // ---------------- USER MENU ----------------
    static void UserMenu(){
        while (true){
            Console.WriteLine("\n--- USER MENU ---");
            Console.WriteLine("1. Display Books");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Checkout Book");
            Console.WriteLine("4. Back");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice){
                case 1: displayBooks(); break;
                case 2:
                    Console.Write("Enter partial title: ");
                    searchBook(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Enter exact title: ");
                    bookStatus(Console.ReadLine());
                    break;
                case 4: return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

}
