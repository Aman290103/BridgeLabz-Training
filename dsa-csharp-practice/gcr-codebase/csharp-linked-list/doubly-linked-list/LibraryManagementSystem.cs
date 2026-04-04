/*Problem Statement: Design a library management system using a doubly linked list. Each node represents a book and contains the following attributes: Book Title, Author, Genre, Book ID, and Availability Status. Implement the following functionalities:
Add a new book at the beginning, end, or at a specific position.
Remove a book by Book ID.
Search for a book by Book Title or Author.
Update a book’s Availability Status.
Display all books in forward and reverse order.
Count the total number of books in the library.
*/

using System;

public class libraryManagementSystem{
      class Node{
        public string title;
        public string author;
        public string genre;
        public int bookId;
        public bool availabilityStatus;
        public Node? next;
        public Node? prev;
        public Node(string title, string author, string genre, int bookId, bool availabilityStatus){
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.bookId = bookId;
            this.availabilityStatus = availabilityStatus;
            this.next = null;
            this.prev = null;
        }
    }
    Node? head = null;
    public void addBookAtBeginning(string title, string author, string genre, int bookId, bool availabilityStatus){
        Node newNode = new Node(title, author, genre, bookId, availabilityStatus);
        if(head == null){
            head = newNode;
        }
        else{
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
    }
    public void addBookAtEnd(string title, string author, string genre, int bookId, bool availabilityStatus){
        Node newNode = new Node(title, author, genre, bookId, availabilityStatus);
        if(head == null){
            head = newNode;
        }
        else{
            Node temp = head;
            while(temp.next != null){
                temp = temp.next;
            }
            temp.next = newNode;
            newNode.prev = temp;
        }
    }
    public void addBookAtPosition(string title, string author, string genre, int bookId, bool availabilityStatus, int position){
        Node newNode = new Node(title, author, genre, bookId, availabilityStatus);
        if(head == null || position == 0){
            addBookAtBeginning(title, author, genre, bookId, availabilityStatus);
        }
        else{
            Node temp = head;
            for(int i = 0; i < position - 1 && temp.next != null; i++){
                temp = temp.next;
            }
            if(temp.next == null){
                addBookAtEnd(title, author, genre, bookId, availabilityStatus);
            }
            else{
                newNode.next = temp.next;
                temp.next.prev = newNode;
                temp.next = newNode;
                newNode.prev = temp;
            }
        }
    }
    public void removeBookById(int bookId){
        if(head == null){
            Console.WriteLine("List is empty");
        }
        else{
            Node temp = head;
            while(temp != null){
                if(temp.bookId == bookId){
                    if(temp.prev == null){
                        head = temp.next;
                        if(temp.next != null){
                            temp.next.prev = null;
                        }
                    }
                    else if(temp.next == null){
                        temp.prev.next = null;
                    }
                    else{
                        temp.prev.next = temp.next;
                        temp.next.prev = temp.prev;
                    }
                    return;
                }
                temp = temp.next;
            }
        }
    }
    public void searchBookByTitle(string title){
        if(head == null){
            Console.WriteLine("List is empty");
        }
        else{
            Node temp = head;
            while(temp != null){
                if(temp.title == title){
                    Console.WriteLine("Book found");
                    Console.WriteLine("Title: " + temp.title);
                    Console.WriteLine("Author: " + temp.author);
                    Console.WriteLine("Genre: " + temp.genre);
                    Console.WriteLine("Book ID: " + temp.bookId);
                    Console.WriteLine("Availability Status: " + temp.availabilityStatus);
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Book not found");
        }
    } 
    public void searchBookByAuthor(string author){
        if(head == null){
            Console.WriteLine("List is empty");
        }
        else{
            Node temp = head;
            while(temp != null){
                if(temp.author == author){
                    Console.WriteLine("Book found");
                    Console.WriteLine("Title: " + temp.title);
                    Console.WriteLine("Author: " + temp.author);
                    Console.WriteLine("Genre: " + temp.genre);
                    Console.WriteLine("Book ID: " + temp.bookId);
                    Console.WriteLine("Availability Status: " + temp.availabilityStatus);
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Book not found");
        }
    }
    public void updateBookAvailabilityStatus(int bookId, bool availabilityStatus){
        if(head == null){
            Console.WriteLine("List is empty");
        }
        else{
            Node temp = head;
            while(temp != null){
                if(temp.bookId == bookId){
                    temp.availabilityStatus = availabilityStatus;
                    Console.WriteLine("Book availability status updated");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Book not found");
        }
    }
    public void displayBooksForward(){
        if(head == null){
            Console.WriteLine("List is empty");
        }
        else{
            Node temp = head;
            while(temp != null){
                Console.WriteLine("Title: " + temp.title);
                Console.WriteLine("Author: " + temp.author);
                Console.WriteLine("Genre: " + temp.genre);
                Console.WriteLine("Book ID: " + temp.bookId);
                Console.WriteLine("Availability Status: " + temp.availabilityStatus);
                temp = temp.next;
            }
        }
    }
    public void displayBooksReverse(){
        if(head == null){
            Console.WriteLine("List is empty");
        }
        else{
            Node temp = head;
            while(temp.next != null){
                temp = temp.next;
            }
            while(temp != null){
                Console.WriteLine("Title: " + temp.title);
                Console.WriteLine("Author: " + temp.author);
                Console.WriteLine("Genre: " + temp.genre);
                Console.WriteLine("Book ID: " + temp.bookId);
                Console.WriteLine("Availability Status: " + temp.availabilityStatus);
                temp = temp.prev;
            }
        }
    }
    public int countBooks(){
        if(head == null){
            return 0;
        }
        else{
            Node temp = head;
            int count = 0;
            while(temp != null){
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
    public static void Main(string[] args){
        libraryManagementSystem lms = new libraryManagementSystem();
        lms.addBookAtBeginning("The Alchemist", "Paulo Coelho", "Fiction", 1, true);
        lms.addBookAtEnd("The Da Vinci Code", "Dan Brown", "Thriller", 2, true);
        lms.addBookAtPosition("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", 3, true, 2);
        lms.removeBookById(2);
        lms.searchBookByTitle("The Alchemist");
        lms.searchBookByAuthor("Paulo Coelo");
        lms.updateBookAvailabilityStatus(1, false);
        lms.displayBooksForward();
        lms.displayBooksReverse();
        Console.WriteLine("Total number of books: " + lms.countBooks());
    }
}