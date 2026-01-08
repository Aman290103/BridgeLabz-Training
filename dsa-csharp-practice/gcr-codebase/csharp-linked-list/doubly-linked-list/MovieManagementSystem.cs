/*Problem Statement: Implement a movie management system using a doubly linked list. Each node will represent a movie and contain Movie Title, Director, Year of Release, and Rating. Implement the following functionalities:
Add a movie record at the beginning, end, or at a specific position.
Remove a movie record by Movie Title.
Search for a movie record by Director or Rating.
Display all movie records in both forward and reverse order.
Update a movie's Rating based on the Movie Title.
*/

using System;

public class MovieManagementSystem{
      class Node{
        public string MovieTitle;
        public string Director;
        public int YearOfRelease;
        public double Rating;
        public Node Next;
        public Node Prev;

        public Node(string movieTitle, string director, int yearOfRelease, double rating){
            MovieTitle = movieTitle;
            Director = director;
            YearOfRelease = yearOfRelease;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }
    private Node head;
    private Node tail;

    public MovieManagementSystem(){
        head = null;
        tail = null;
    }
    public void AddMovieAtBeginning(string movieTitle, string director, int yearOfRelease, double rating){
        Node newNode = new Node(movieTitle, director, yearOfRelease, rating);
        if(head == null){
            head = newNode;
            tail = newNode;
        }
        else{
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
    }
    public void AddMovieAtEnd(string movieTitle, string director, int yearOfRelease, double rating){
        Node newNode = new Node(movieTitle, director, yearOfRelease, rating);
        if(tail == null){
            head = newNode;
            tail = newNode;
        }
        else{
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    public void AddMovieAtPosition(string movieTitle, string director, int yearOfRelease, double rating, int position){
        Node newNode = new Node(movieTitle, director, yearOfRelease, rating);
        if(position <= 0){
            AddMovieAtBeginning(movieTitle, director, yearOfRelease, rating);
        }
        else{
            Node current = head;
            int currentPosition = 1;
            while(current != null && currentPosition < position){
                current = current.Next;
                currentPosition++;
            }
            if(current == null){
                AddMovieAtEnd(movieTitle, director, yearOfRelease, rating);
            }
            else{
                newNode.Next = current;
                newNode.Prev = current.Prev;
                current.Prev.Next = newNode;
                current.Prev = newNode;
            }
        }
    }

    public void RemoveMovieByTitle(string movieTitle){
        Node current = head;
        while(current != null){
            if(current.MovieTitle == movieTitle){
                if(current.Prev != null){
                    current.Prev.Next = current.Next;
                }
                else{
                    head = current.Next;
                }
                if(current.Next != null){
                    current.Next.Prev = current.Prev;
                }
                else{
                    tail = current.Prev;
                }
                return;
            }
            current = current.Next;
        }
    }

    public void SearchByDirector(string director){
        Node current = head;
        while(current != null){
            if(current.Director == director){
                Console.WriteLine($"Movie Title: {current.MovieTitle}, Director: {current.Director}, Year of Release: {current.YearOfRelease}, Rating: {current.Rating}");
            }
            current = current.Next;
        }
    }
    public void SearchByRating(double rating){
        Node current = head;
        while(current != null){
            if(current.Rating == rating){
                Console.WriteLine($"Movie Title: {current.MovieTitle}, Director: {current.Director}, Year of Release: {current.YearOfRelease}, Rating: {current.Rating}");
            }
            current = current.Next;
        }
    }
    public void DisplayForward(){
        Node current = head;
        while(current != null){
            Console.WriteLine($"Movie Title: {current.MovieTitle}, Director: {current.Director}, Year of Release: {current.YearOfRelease}, Rating: {current.Rating}");
            current = current.Next;
        }
    } 
    public void DisplayReverse(){
        Node current = tail;
        while(current != null){
            Console.WriteLine($"Movie Title: {current.MovieTitle}, Director: {current.Director}, Year of Release: {current.YearOfRelease}, Rating: {current.Rating}");
            current = current.Prev;
        }
    }
    public void UpdateRatingByTitle(string movieTitle, double newRating){
        Node current = head;
        while(current != null){
            if(current.MovieTitle == movieTitle){
                current.Rating = newRating;
                return;
            }
            current = current.Next;
        }
    }
    public static void Main(string[] args){
        MovieManagementSystem movieManagementSystem = new MovieManagementSystem();
        movieManagementSystem.AddMovieAtBeginning("Inception", "Christopher Nolan", 2010, 8.8);
        movieManagementSystem.AddMovieAtEnd("The Dark Knight", "Christopher Nolan", 2008, 9.0);
        movieManagementSystem.AddMovieAtPosition("Interstellar", "Christopher Nolan", 2014, 8.6, 2);
        movieManagementSystem.RemoveMovieByTitle("Inception");
        movieManagementSystem.SearchByDirector("Christopher Nolan");
        movieManagementSystem.SearchByRating(8.8);
        movieManagementSystem.DisplayForward();
        movieManagementSystem.DisplayReverse();
        movieManagementSystem.UpdateRatingByTitle("The Dark Knight", 9.5);
    }
}