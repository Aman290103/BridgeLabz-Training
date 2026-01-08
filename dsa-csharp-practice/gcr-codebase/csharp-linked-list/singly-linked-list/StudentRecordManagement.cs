/*Problem Statement: Create a program to manage student records using a singly linked list. Each node will store information about a student, including their Roll Number, Name, Age, and Grade. Implement the following operations:
Add a new student record at the beginning, end, or at a specific position.
Delete a student record by Roll Number.
Search for a student record by Roll Number.
Display all student records.
Update a student's grade based on their Roll Number.*/

using System;

public class StudentRecordManagement{
      class Node{
        public int RollNumber;
        public string Name;
        public int Age;
        public int Grade;
        public Node Next;

        public Node(int rollNumber, string name, int age, int grade){
            RollNumber = rollNumber;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }
    static Node head = null;

    static void AddStudentAtBeginning(int rollNumber, string name, int age, int grade){
        Node newNode = new Node(rollNumber, name, age, grade);
        if(head == null){
            head = newNode;
        }
        else{
            newNode.Next = head;
            head = newNode;
        }
        Console.WriteLine("Student record added successfully.");
    }

    static void AddStudentAtEnd(int rollNumber, string name, int age, int grade){
        Node newNode = new Node(rollNumber, name, age, grade);
        if(head == null){
            head = newNode;
        }
        else{
            Node current = head;
            while(current.Next != null){
                current = current.Next;
            }
            current.Next = newNode;
        }
        Console.WriteLine("Student record added successfully.");
    }

      static void DeleteStudentByRollNumber(int rollNumber){
        if(head == null){
            Console.WriteLine("No student records found.");
            return;
        }
        if(head.RollNumber == rollNumber){
            head = head.Next;
            Console.WriteLine("Student record deleted successfully.");
            return;
        }
        Node current = head;
        while(current.Next != null){
            if(current.Next.RollNumber == rollNumber){
                current.Next = current.Next.Next;
                Console.WriteLine("Student record deleted successfully.");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Student record not found.");
    }
    static void SearchStudentByRollNumber(int rollNumber){
        if(head == null){
            Console.WriteLine("No student records found.");
            return;
        }
        Node current = head;
        while(current != null){
            if(current.RollNumber == rollNumber){
                Console.WriteLine($"Roll Number: {current.RollNumber}, Name: {current.Name}, Age: {current.Age}, Grade: {current.Grade}");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Student record not found.");
    }

    void DisplayAllStudentRecords(){
        if(head == null){
            Console.WriteLine("No student records found.");
            return;
        }
        Node current = head;
        while(current != null){
            Console.WriteLine($"Roll Number: {current.RollNumber}, Name: {current.Name}, Age: {current.Age}, Grade: {current.Grade}");
            current = current.Next;
        }
    }
    void updateStudentGrade(int rollNumber, int newGrade){
        if(head == null){
            Console.WriteLine("No student records found.");
            return;
        }
        Node current = head;
        while(current != null){
            if(current.RollNumber == rollNumber){
                current.Grade = newGrade;
                Console.WriteLine("Student grade updated successfully.");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Student record not found.");
    }

    public static void Main(string[] args){
        StudentRecordManagement studentRecordManagement = new StudentRecordManagement();
        while(true){
            Console.WriteLine("1. Add a new student record at the beginning");
            Console.WriteLine("2. Add a new student record at the end");
            Console.WriteLine("3. Delete a student record by Roll Number");
            Console.WriteLine("4. Search for a student record by Roll Number");
            Console.WriteLine("5. Display all student records");
            Console.WriteLine("6. Update a student's grade based on their Roll Number");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.Write("Enter Roll Number: ");
                    int rollNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    int grade = int.Parse(Console.ReadLine());
                    AddStudentAtBeginning(rollNumber, name, age, grade);
                    break;
                case 2:
                    Console.Write("Enter Roll Number: ");
                    rollNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Grade: ");
                    grade = int.Parse(Console.ReadLine());
                    AddStudentAtEnd(rollNumber, name, age, grade);
                    break;
                case 3:
                    Console.Write("Enter Roll Number: ");
                    rollNumber = int.Parse(Console.ReadLine());
                    DeleteStudentByRollNumber(rollNumber);
                    break;
                case 4:
                    Console.Write("Enter Roll Number: ");
                    rollNumber = int.Parse(Console.ReadLine());
                    SearchStudentByRollNumber(rollNumber);
                    break;
                case 5:
                    studentRecordManagement.DisplayAllStudentRecords();
                    break;
                case 6:
                    Console.Write("Enter Roll Number: ");
                    rollNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Grade: ");
                    grade = int.Parse(Console.ReadLine());
                    studentRecordManagement.updateStudentGrade(rollNumber, grade);
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }


}
