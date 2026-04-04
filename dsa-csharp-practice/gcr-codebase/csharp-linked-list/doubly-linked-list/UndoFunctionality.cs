/*Undo/Redo Functionality for Text Editor
Problem Statement: Design an undo/redo functionality for a text editor using a doubly linked list. Each node represents a state of the text content (e.g., after typing a word or performing a command). Implement the following:
Add a new text state at the end of the list every time the user types or performs an action.
Implement the undo functionality (revert to the previous state).
Implement the redo functionality (revert back to the next state after undo).
Display the current state of the text.
Limit the undo/redo history to a fixed size (e.g., last 10 states).
*/

using System;

public class TextEditor{
      class Node{
            public string data;
            public Node next;
            public Node prev;
            public Node(string data){
                  this.data = data;
                  this.next = null;
                  this.prev = null;
            }
      }
      Node head;

      public TextEditor(){
            head = null;
      }
      public void AddText(string data){
            Node newNode = new Node(data);
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
      public void Undo(){
            if(head == null || head.prev == null){
                  Console.WriteLine("No more undo operations");
                  return;
            }
            head = head.prev;
      }
      public void Redo(){
            if(head == null || head.next == null){
                  Console.WriteLine("No more redo operations");
                  return;
            }
            head = head.next;
      }
      public void Display(){
            Node temp = head;
            while(temp != null){
                  Console.Write(temp.data + " ");
                  temp = temp.next;
            }
            Console.WriteLine();
      }
      public static void Main(string[] args){
            TextEditor editor = new TextEditor();
            editor.AddText("Hello");
            editor.AddText("World");
            editor.AddText("!");
            editor.Display();
            editor.Undo();
            editor.Display();
            editor.Redo();
            editor.Display();
      }
}