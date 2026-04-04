/*Problem Statement: Create a system to manage social media friend connections using a singly linked list. Each node represents a user with User ID, Name, Age, and List of Friend IDs. Implement the following operations:
Add a friend connection between two users.
Remove a friend connection.
Find mutual friends between two users.
Display all friends of a specific user.
Search for a user by Name or User ID.
Count the number of friends for each user.
*/

using System;

public class SocialMedia{
      class Node{
        public int userId;
        public string name;
        public int age;
        public Node next;
        public Node(int userId, string name, int age){
            this.userId = userId;
            this.name = name;
            this.age = age;
            this.next = null;
        }
    }
    Node head = null;
    public void AddFriend(int userId, string name, int age){
        Node newNode = new Node(userId, name, age);
        if(head == null){
            head = newNode;
        }
        else{
            Node current = head;
            while(current.next != null){
                current = current.next;
            }
            current.next = newNode;
        }
    }
    public void RemoveFriend(int userId){
        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        if(head.userId == userId){
            head = head.next;
            return;
        }
        Node current = head;
        while(current.next != null){
            if(current.next.userId == userId){
                current.next = current.next.next;
                return;
            }
            current = current.next;
        }
        Console.WriteLine("User not found");
    }
    public void FindMutualFriends(int userId1, int userId2){
        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        Node current = head;
        while(current != null){
            if(current.userId == userId1){
                Node current2 = head;
                while(current2 != null){
                    if(current2.userId == userId2){
                        Console.WriteLine("Mutual friends: ");
                        Console.WriteLine(current.name + " and " + current2.name);
                        return;
                    }
                    current2 = current2.next;
                }
            }
            current = current.next;
        }
        Console.WriteLine("User not found");
    }
    public void DisplayFriends(int userId){
        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        Node current = head;
        while(current != null){
            if(current.userId == userId){
                Console.WriteLine("Friends of " + current.name + ": ");
                Node current2 = head;
                while(current2 != null){
                    if(current2.userId != userId){
                        Console.WriteLine(current2.name);
                    }
                    current2 = current2.next;
                }
                return;
            }
            current = current.next;
        }
        Console.WriteLine("User not found");
    }
    public void SearchUser(string name){
        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        Node current = head;
        while(current != null){
            if(current.name == name){
                Console.WriteLine("User found: " + current.name);
                return;
            }
            current = current.next;
        }
        Console.WriteLine("User not found");
    }
    public void CountFriends(int userId){
        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        Node current = head;
        while(current != null){
            if(current.userId == userId){
                Console.WriteLine("Friends of " + current.name + ": ");
                Node current2 = head;
                int count = 0;
                while(current2 != null){
                    if(current2.userId != userId){
                        count++;
                    }
                    current2 = current2.next;
                }
                Console.WriteLine(count);
                return;
            }
            current = current.next;
        }
        Console.WriteLine("User not found");
    }

    public static void Main(string[] args){
        SocialMedia sm = new SocialMedia();
        sm.AddFriend(1, "Jam", 20);
        sm.AddFriend(2, "Jan", 21);
        sm.AddFriend(3, "Jao", 22);
        sm.AddFriend(4, "Jap", 23);
        sm.AddFriend(5, "Jaq", 24);
        sm.AddFriend(6, "Jar", 25);
        sm.AddFriend(7, "Jas", 26);
        sm.AddFriend(8, "Jat", 27);
        sm.AddFriend(9, "Jau", 28);
        sm.AddFriend(10, "Jav", 29);
        sm.RemoveFriend(1);
        sm.FindMutualFriends(2, 3);
        sm.DisplayFriends(4);
        sm.SearchUser("Jill");
        sm.CountFriends(5);
    }
}