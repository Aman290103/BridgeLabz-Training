/*Problem Statement: Implement a round-robin CPU scheduling algorithm using a circular linked list. Each node will represent a process and contain Process ID, Burst Time, and Priority. Implement the following functionalities:
Add a new process at the end of the circular list.
Remove a process by Process ID after its execution.
Simulate the scheduling of processes in a round-robin manner with a fixed time quantum.
Display the list of processes in the circular queue after each round.
Calculate and display the average waiting time and turn-around time for all processes.
*/

using System;

public class RoundRobinScheduling{
      class Node{
        public int processId;
        public int burstTime;
        public int priority;
        public Node next;
        public Node(int processId, int burstTime, int priority){
            this.processId = processId;
            this.burstTime = burstTime;
            this.priority = priority;
            this.next = null;
        }
    }
    Node head = null;
    public void AddProcessAtEnd(int processId, int burstTime, int priority){
        Node newNode = new Node(processId, burstTime, priority);
        if(head == null){
            head = newNode;
            head.next = head;
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
    public void RemoveProcessById(int processId){
        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        if(head.processId == processId){
            if(head.next == head){
                head = null;
            }
            else{
                Node temp = head;
                while(temp.next != head){
                    temp = temp.next;
                }
                temp.next = head.next;
                head = head.next;
            }
        }
        else{
            Node temp = head;
            while(temp.next != head){
                if(temp.next.processId == processId){
                    temp.next = temp.next.next;
                    break;
                }
                temp = temp.next;
            }
        }
    }
    public void RoundRobinSchedulingAlgorithm(int timeQuantum){
        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        Node temp = head;
        while(temp.next != head){
            if(temp.burstTime > timeQuantum){
                temp.burstTime -= timeQuantum;
                temp = temp.next;
            }
            else{
                temp.burstTime = 0;
                temp = temp.next;
            }
        }
    }
    public void DisplayList(){
        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        Node temp = head;
        do{
            Console.WriteLine("Process ID: " + temp.processId + " Burst Time: " + temp.burstTime + " Priority: " + temp.priority);
            temp = temp.next;
        }while(temp != head);
    }
    public void CalculateAverageWaitingTimeAndTurnAroundTime(){
        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        Node temp = head;
        int totalWaitingTime = 0;
        int totalTurnAroundTime = 0;
        int totalProcesses = 0;
        do{
            totalWaitingTime += temp.burstTime;
            totalTurnAroundTime += temp.burstTime;
            totalProcesses++;
            temp = temp.next;
        }while(temp != head);
        Console.WriteLine("Average Waiting Time: " + (totalWaitingTime/totalProcesses));
        Console.WriteLine("Average Turn Around Time: " + (totalTurnAroundTime/totalProcesses));
    }
    public static void Main(string[] args){
        RoundRobinScheduling roundRobinScheduling = new RoundRobinScheduling();
        roundRobinScheduling.AddProcessAtEnd(1, 10, 1);
        roundRobinScheduling.AddProcessAtEnd(2, 5, 2);
        roundRobinScheduling.AddProcessAtEnd(3, 8, 3);
        roundRobinScheduling.DisplayList();
        roundRobinScheduling.RoundRobinSchedulingAlgorithm(2);
        roundRobinScheduling.DisplayList();
        roundRobinScheduling.CalculateAverageWaitingTimeAndTurnAroundTime();
    }
}