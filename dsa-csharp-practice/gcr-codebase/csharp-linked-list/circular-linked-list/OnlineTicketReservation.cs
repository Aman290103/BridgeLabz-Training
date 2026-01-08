/*Online Ticket Reservation System
Problem Statement: Design an online ticket reservation system using a circular linked list, where each node represents a booked ticket. Each node will store the following information: Ticket ID, Customer Name, Movie Name, Seat Number, and Booking Time. Implement the following functionalities:
Add a new ticket reservation at the end of the circular list.
Remove a ticket by Ticket ID.
Display the current tickets in the list.
Search for a ticket by Customer Name or Movie Name.
Calculate the total number of booked tickets.
*/

using System;

public class OnlineTicketReservation{
      class Node{
        public int ticketId;
        public string customerName;
        public string movieName;
        public int seatNumber;
        public DateTime bookingTime;
        public Node? next;

        public Node(int ticketId, string customerName, string movieName, int seatNumber, DateTime bookingTime){
            this.ticketId = ticketId;
            this.customerName = customerName;
            this.movieName = movieName;
            this.seatNumber = seatNumber;
            this.bookingTime = bookingTime;
            this.next = null;
        }
    }
    
    Node? head = null;
    
    public void AddTicketReservation(int ticketId, string customerName, string movieName, int seatNumber, DateTime bookingTime){
        Node newNode = new Node(ticketId, customerName, movieName, seatNumber, bookingTime);
        if(head == null){
            head = newNode;
            newNode.next = head; // Point to itself to make it circular
        }
        else{
            Node temp = head;
            while(temp.next != head){
                temp = temp.next;
            }
            temp.next = newNode;
            newNode.next = head;
        }
    }
    
    public void RemoveTicketById(int ticketId){
        if(head == null){
            Console.WriteLine("No tickets found");
            return;
        }
        
        Node temp = head;
        Node prev = null;
        
        // If head node is to be deleted
        if(head.ticketId == ticketId){
            if(head.next == head){ // Only one node
                head = null;
            }
            else{
                // Find last node
                while(temp.next != head){
                    temp = temp.next;
                }
                temp.next = head.next;
                head = head.next;
            }
            Console.WriteLine($"Ticket {ticketId} removed successfully");
            return;
        }
        
        // Search for the node to delete
        do{
            prev = temp;
            temp = temp.next;
            if(temp.ticketId == ticketId){
                prev.next = temp.next;
                Console.WriteLine($"Ticket {ticketId} removed successfully");
                return;
            }
        } while(temp != head);
        
        Console.WriteLine($"Ticket {ticketId} not found");
    }
    
    public void DisplayTickets(){
        if(head == null){
            Console.WriteLine("No tickets found");
            return;
        }
        
        Node temp = head;
        Console.WriteLine("Current Ticket Reservations:");
        do{
            Console.WriteLine($"Ticket ID: {temp.ticketId}, Customer: {temp.customerName}, Movie: {temp.movieName}, Seat: {temp.seatNumber}, Booking Time: {temp.bookingTime}");
            temp = temp.next;
        } while(temp != head);
    }
    
    public void SearchTicketByCustomerName(string customerName){
        if(head == null){
            Console.WriteLine("No tickets found");
            return;
        }
        
        Node temp = head;
        bool found = false;
        do{
            if(temp.customerName.Equals(customerName, StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine($"Ticket found - ID: {temp.ticketId}, Customer: {temp.customerName}, Movie: {temp.movieName}, Seat: {temp.seatNumber}, Booking Time: {temp.bookingTime}");
                found = true;
            }
            temp = temp.next;
        } while(temp != head);
        
        if(!found){
            Console.WriteLine($"No tickets found for customer: {customerName}");
        }
    }
    
    public void SearchTicketByMovieName(string movieName){
        if(head == null){
            Console.WriteLine("No tickets found");
            return;
        }
        
        Node temp = head;
        bool found = false;
        do{
            if(temp.movieName.Equals(movieName, StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine($"Ticket found - ID: {temp.ticketId}, Customer: {temp.customerName}, Movie: {temp.movieName}, Seat: {temp.seatNumber}, Booking Time: {temp.bookingTime}");
                found = true;
            }
            temp = temp.next;
        } while(temp != head);
        
        if(!found){
            Console.WriteLine($"No tickets found for movie: {movieName}");
        }
    }
    
    public int CalculateTotalBookedTickets(){
        if(head == null){
            return 0;
        }
        
        Node temp = head;
        int count = 0;
        do{
            count++;
            temp = temp.next;
        } while(temp != head);
        
        return count;
    }
    
    public static void Main(string[] args){
        OnlineTicketReservation system = new OnlineTicketReservation();
        
        // Add ticket reservations
        system.AddTicketReservation(1, "John Doe", "Avengers", 15, DateTime.Now);
        system.AddTicketReservation(2, "Jane Smith", "Spider-Man", 20, DateTime.Now);
        system.AddTicketReservation(3, "Bob Johnson", "Avengers", 25, DateTime.Now);
        
        // Display all tickets
        system.DisplayTickets();
        
        // Search by customer name
        Console.WriteLine("\nSearching for John Doe:");
        system.SearchTicketByCustomerName("John Doe");
        
        // Search by movie name
        Console.WriteLine("\nSearching for Avengers:");
        system.SearchTicketByMovieName("Avengers");
        
        // Calculate total tickets
        Console.WriteLine($"\nTotal booked tickets: {system.CalculateTotalBookedTickets()}");
        
        // Remove a ticket
        Console.WriteLine("\nRemoving ticket ID 2:");
        system.RemoveTicketById(2);
        
        // Display tickets after removal
        Console.WriteLine("\nTickets after removal:");
        system.DisplayTickets();
        
        Console.WriteLine($"\nTotal booked tickets after removal: {system.CalculateTotalBookedTickets()}");
    }
}