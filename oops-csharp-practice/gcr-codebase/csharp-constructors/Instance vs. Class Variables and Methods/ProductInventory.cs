/*Problem 1: Product Inventory
Create a Product class with:
Instance Variables: productName, price.
Class Variable: totalProducts (shared among all products).
Implement the following methods:
An instance method DisplayProductDetails() to display the details of a product.
A class method DisplayTotalProducts() to show the total number of products created.
*/

using System;

public class Product
{
    public string productName;
    public double price;
    public static int totalProducts = 0;

    public Product(string productName, double price){
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    public void DisplayProductDetails(){
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Price: ${price}");
    }

    public static void DisplayTotalProducts(){
        Console.WriteLine($"Total Products: {totalProducts}");
    }
}
public class Program{
    public static void Main(string[] args){
        Product product1 = new Product("Lenevo Laptop", 999.99);
        Product product2 = new Product("Smartphone", 499.99);
        product1.DisplayProductDetails();
        product2.DisplayProductDetails();
        Product.DisplayTotalProducts();
    }
}
