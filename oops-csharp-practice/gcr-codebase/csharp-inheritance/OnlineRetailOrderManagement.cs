/*Online Retail Order Management
Description: Create a multilevel hierarchy to manage orders, where Order is the base class, ShippedOrder is a subclass, and DeliveredOrder extends ShippedOrder.
Tasks:
Define a base class Order with common attributes like orderId and OrderDate.
Create a subclass ShippedOrder with additional attributes like TrackingNumber.
Create another subclass DeliveredOrder extending ShippedOrder, adding a DeliveryDate attribute.
Implement a method GetOrderStatus() to return the current order status based on the class level.
Goal: Explore multilevel inheritance, showing how attributes and methods can be added across a chain of classes.
*/

using System;

class Order{
    public int OrderId;
    public DateTime OrderDate;
    public Order(int orderId, DateTime orderDate){
        this.OrderId = orderId;
        this.OrderDate = orderDate;
    }
    public virtual string GetOrderStatus(){
        return "Order Placed";
    }
}     
class ShippedOrder : Order{
    public string TrackingNumber { get; set; }
    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate){
        TrackingNumber = trackingNumber;
    }
    public override string GetOrderStatus(){
        return "Order Shipped";
    }
}     
class DeliveredOrder : ShippedOrder{
    public DateTime DeliveryDate { get; set; }
    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber){
        DeliveryDate = deliveryDate;
    }
    public override string GetOrderStatus(){
        return "Order Delivered";
    }
}
class OnlineRetailOrderManagement{
    public static void Main(){
        Order order = new Order(1, DateTime.Now);
        ShippedOrder shippedOrder = new ShippedOrder(2, DateTime.Now, "ABC123");
        DeliveredOrder deliveredOrder = new DeliveredOrder(3, DateTime.Now, "XYZ789", DateTime.Now.AddDays(5));

        Console.WriteLine($"Order Status: {order.GetOrderStatus()}");
        Console.WriteLine($"Shipped Order Status: {shippedOrder.GetOrderStatus()}");
        Console.WriteLine($"Delivered Order Status: {deliveredOrder.GetOrderStatus()}");
    }
}
