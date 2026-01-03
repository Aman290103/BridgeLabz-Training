/*Sample Program 4: Shopping Cart System
Create a Product class to manage shopping cart items with the following features:
static: 
A static variable Discount shared by all products.
A static method UpdateDiscount() to modify the discount percentage.
this: 
Use this to initialize ProductName, Price, and Quantity in the constructor.
readonly: 
Use a readonly variable ProductID to ensure each product has a unique identifier that cannot be changed.
is operator: 
Validate whether an object is an instance of the Product class before processing its details.
*/

using System;

public class Product{
    // Static variable to store the discount percentage
    public static double Discount { get; private set; } = 0.0;
    public static void UpdateDiscount(double newDiscount){
        Discount = newDiscount;
    }
    public readonly int ProductID;
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    // Constructor to initialize product details
    public Product(int id, string name, double price, int quantity){
        this.ProductID = id;
        this.ProductName = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    // Method to calculate the total price with discount
    public double CalculateTotalPrice(){
        double discountedPrice = Price * (1 - Discount / 100);
        return discountedPrice * Quantity;
    }
}
public class ShoppingCartSystem{
    public static void Main(string[] args){
        // Update the discount percentage
        Product.UpdateDiscount(10.0);

        // Create product instances
        Product product1 = new Product(1, "Laptop", 1000.0, 2);
        Product product2 = new Product(2, "Smartphone", 500.0, 3);

        // Check if an object is an instance of Product
        if (product1 is Product){
            Console.WriteLine($"Product 1 Total Price: ${product1.CalculateTotalPrice()}");
        }

        if (product2 is Product){
            Console.WriteLine($"Product 2 Total Price: ${product2.CalculateTotalPrice()}");
        }
    }
}
