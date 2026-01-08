/*Problem Statement: Design an inventory management system using a singly linked list where each node stores information about an item such as Item Name, Item ID, Quantity, and Price. Implement the following functionalities:
Add an item at the beginning, end, or at a specific position.
Remove an item based on Item ID.
Update the quantity of an item by Item ID.
Search for an item based on Item ID or Item Name.
Calculate and display the total value of inventory (Sum of Price * Quantity for each item).
Sort the inventory based on Item Name or Price in ascending or descending order.
*/

using System;

public class Inventory{
      class Node{
            public string ItemName;
            public int ItemId;
            public int Quantity;
            public double Price;
            public Node? Next;
            public Node(string itemName, int itemId, int quantity, double price){
                  ItemName = itemName;
                  ItemId = itemId;
                  Quantity = quantity;
                  Price = price;
                  Next = null;
            }
      }
      static Node? head = null;
      public static void AddItemAtBeginning(string itemName, int itemId, int quantity, double price){
            Node newNode = new Node(itemName, itemId, quantity, price);
            if(head == null){
                  head = newNode;
            }
            else{
                  Node temp = head;
                  while(temp.Next != null){
                        temp = temp.Next;
                  }
                  temp.Next = newNode;
            }
      }
      public static void AddItemAtEnd(string itemName, int itemId, int quantity, double price){
            Node newNode = new Node(itemName, itemId, quantity, price);
            if(head == null){
                  head = newNode;
            }
            else{
                  Node temp = head;
                  while(temp.Next != null){
                        temp = temp.Next;
                  }
                  temp.Next = newNode;
            }
      }
      public static void AddItemAtPosition(string itemName, int itemId, int quantity, double price, int position){
            Node newNode = new Node(itemName, itemId, quantity, price);
            if(head == null){
                  head = newNode;
            }
            else{
                  Node temp = head;
                  for(int i = 0; i < position - 1; i++){
                        temp = temp.Next;
                  }
                  newNode.Next = temp.Next;
                  temp.Next = newNode;
            }
      }     
      public static void RemoveItemByItemId(int itemId){
            if(head == null){
                  Console.WriteLine("Inventory is empty");
            }
            else{
                  Node temp = head;
                  Node prev = null;
                  while(temp != null){
                        if(temp.ItemId == itemId){
                              if(prev == null){
                                    head = temp.Next;
                              }
                              else{
                                    prev.Next = temp.Next;
                              }
                              break;
                        }
                        prev = temp;
                        temp = temp.Next;
                  }
            }
      }
      public static void UpdateQuantityByItemId(int itemId, int quantity){
            if(head == null){
                  Console.WriteLine("Inventory is empty");
            }
            else{
                  Node temp = head;
                  while(temp != null){
                        if(temp.ItemId == itemId){
                              temp.Quantity = quantity;
                              break;
                        }
                        temp = temp.Next;
                  }
            }
      }
      public static void SearchItemByItemId(int itemId){
            if(head == null){
                  Console.WriteLine("Inventory is empty");
            }
            else{
                  Node temp = head;
                  while(temp != null){
                        if(temp.ItemId == itemId){
                              Console.WriteLine("Item Name: " + temp.ItemName);
                              Console.WriteLine("Item ID: " + temp.ItemId);
                              Console.WriteLine("Quantity: " + temp.Quantity);
                              Console.WriteLine("Price: " + temp.Price);
                              break;
                        }
                        temp = temp.Next;
                  }
            }
      }
      public static void SearchItemByItemName(string itemName){
            if(head == null){
                  Console.WriteLine("Inventory is empty");
            }
            else{
                  Node temp = head;
                  while(temp != null){
                        if(temp.ItemName == itemName){
                              Console.WriteLine("Item Name: " + temp.ItemName);
                              Console.WriteLine("Item ID: " + temp.ItemId);
                              Console.WriteLine("Quantity: " + temp.Quantity);
                              Console.WriteLine("Price: " + temp.Price);
                              break;
                        }
                        temp = temp.Next;
                  }
            }
      }
      public static void CalculateTotalValueOfInventory(){
            if(head == null){
                  Console.WriteLine("Inventory is empty");
            }
            else{
                  Node temp = head;
                  double totalValue = 0;
                  while(temp != null){
                        totalValue += temp.Quantity * temp.Price;
                        temp = temp.Next;
                  }
                  Console.WriteLine("Total Value of Inventory: " + totalValue);
            }
      }
      public static void SortInventoryByItemName(){
            if(head == null){
                  Console.WriteLine("Inventory is empty");
            }
            else{
                  Node temp = head;
                  while(temp != null){
                        Node temp2 = temp.Next;
                        while(temp2 != null){
                              if(temp.ItemName.CompareTo(temp2.ItemName) > 0){
                                    string itemName = temp.ItemName;
                                    int itemId = temp.ItemId;
                                    int quantity = temp.Quantity;
                                    double price = temp.Price;
                                    temp.ItemName = temp2.ItemName;
                                    temp.ItemId = temp2.ItemId;
                                    temp.Quantity = temp2.Quantity;
                                    temp.Price = temp2.Price;
                                    temp2.ItemName = itemName;
                                    temp2.ItemId = itemId;
                                    temp2.Quantity = quantity;
                                    temp2.Price = price;
                              }
                              temp2 = temp2.Next;
                        }
                        temp = temp.Next;
                  }
            }
      }     
     public static void SortInventoryByPrice(){
            if(head == null){
                  Console.WriteLine("Inventory is empty");
            }
            else{
                  Node temp = head;
                  while(temp != null){
                        Node temp2 = temp.Next;
                        while(temp2 != null){
                              if(temp.Price > temp2.Price){
                                    string itemName = temp.ItemName;
                                    int itemId = temp.ItemId;
                                    int quantity = temp.Quantity;
                                    double price = temp.Price;
                                    temp.ItemName = temp2.ItemName;
                                    temp.ItemId = temp2.ItemId;
                                    temp.Quantity = temp2.Quantity;
                                    temp.Price = temp2.Price;
                                    temp2.ItemName = itemName;
                                    temp2.ItemId = itemId;
                                    temp2.Quantity = quantity;
                                    temp2.Price = price;
                              }
                              temp2 = temp2.Next;
                        }
                        temp = temp.Next;
                  }
            }
      }
      public static void Main(string[] args){
            AddItemAtBeginning("Item1", 1, 10, 100);
            AddItemAtEnd("Item2", 2, 20, 200);
            AddItemAtPosition("Item3", 3, 30, 300, 1);
            RemoveItemByItemId(2);
            UpdateQuantityByItemId(1, 50);
            SearchItemByItemId(1);
            SearchItemByItemName("Item3");
            CalculateTotalValueOfInventory();
            SortInventoryByItemName();
            SortInventoryByPrice();
      }
}