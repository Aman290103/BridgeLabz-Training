/*Problem Statement: Create a task scheduler using a circular linked list. Each node in the list represents a task with Task ID, Task Name, Priority, and Due Date. Implement the following functionalities:
Add a task at the beginning, end, or at a specific position in the circular list.
Remove a task by Task ID.
View the current task and move to the next task in the circular list.
Display all tasks in the list starting from the head node.
Search for a task by Priority.
*/

using System;

public class TaskScheduler{
      class Node{
        public int TaskId;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public Node Next;
        public Node(int taskId, string taskName, int priority, DateTime dueDate){
            TaskId = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }
    private Node head;

    public TaskScheduler(){
        head = null;
    }

    public void AddTaskAtBeginning(int taskId, string taskName, int priority, DateTime dueDate){
        Node newNode = new Node(taskId, taskName, priority, dueDate);
        if(head == null){
            head = newNode;
            head.Next = head;
        }else{
            Node current = head;
            while(current.Next != head){
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Next = head;
        }
    }
    public void AddTaskAtEnd(int taskId, string taskName, int priority, DateTime dueDate){
        Node newNode = new Node(taskId, taskName, priority, dueDate);
        if(head == null){
            head = newNode;
            head.Next = head;
        }else{
            Node current = head;
            while(current.Next != head){
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Next = head;
        }
    }
    public void AddTaskAtPosition(int taskId, string taskName, int priority, DateTime dueDate, int position){
        Node newNode = new Node(taskId, taskName, priority, dueDate);
        if(position == 0){
            AddTaskAtBeginning(taskId, taskName, priority, dueDate);
        }else{
            Node current = head;
            for(int i = 0; i < position - 1; i++){
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }
    public void RemoveTaskById(int taskId){
        if(head == null){
            return;
        }
        if(head.TaskId == taskId){
            if(head.Next == head){
                head = null;
            }else{
                Node current = head;
                while(current.Next != head){
                    current = current.Next;
                }
                current.Next = head.Next;
                head = head.Next;
            }
        }else{
            Node current = head;
            while(current.Next != head){
                if(current.Next.TaskId == taskId){
                    current.Next = current.Next.Next;
                    break;
                }
                current = current.Next;
            }
        }
    }
    public void ViewCurrentTask(){
        if(head == null){
            Console.WriteLine("No tasks in the list");
        }else{
            Console.WriteLine("Current Task: " + head.TaskName);
        }
    }
    public void DisplayAllTasks(){
        if(head == null){
            Console.WriteLine("No tasks in the list");
        }else{
            Node current = head;
            do{
                Console.WriteLine("Task ID: " + current.TaskId + ", Task Name: " + current.TaskName + ", Priority: " + current.Priority + ", Due Date: " + current.DueDate);
                current = current.Next;
            }while(current != head);
        }
    }
    public void SearchTaskByPriority(int priority){
        if(head == null){
            Console.WriteLine("No tasks in the list");
        }else{
            Node current = head;
            do{
                if(current.Priority == priority){
                    Console.WriteLine("Task ID: " + current.TaskId + ", Task Name: " + current.TaskName + ", Priority: " + current.Priority + ", Due Date: " + current.DueDate);
                }
                current = current.Next;
            }while(current != head);
        }
    }
    public static void Main(string[] args){
        TaskScheduler taskScheduler = new TaskScheduler();
        taskScheduler.AddTaskAtBeginning(1, "Task 1", 1, DateTime.Now.AddDays(1));
        taskScheduler.AddTaskAtEnd(2, "Task 2", 2, DateTime.Now.AddDays(2));
        taskScheduler.AddTaskAtPosition(3, "Task 3", 3, DateTime.Now.AddDays(3), 1);
        taskScheduler.DisplayAllTasks();
        taskScheduler.RemoveTaskById(2);
        taskScheduler.DisplayAllTasks();
        taskScheduler.ViewCurrentTask();
        taskScheduler.SearchTaskByPriority(3);
    } 

}