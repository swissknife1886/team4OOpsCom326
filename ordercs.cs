using System;
using System.Collections.Generic;

public class Order
{
    // Properties
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
    public string OrderStatus { get; set; } // E.g., "Pending", "Completed"
    public double OrderTotal { get; set; }

    private static List<Order> orders = new List<Order>();

    // Constructor
    public Order(int orderID, int customerID, DateTime orderDate, string orderStatus, double orderTotal)
    {
        OrderID = orderID;
        CustomerID = customerID;
        OrderDate = orderDate;
        OrderStatus = orderStatus;
        OrderTotal = orderTotal;
    }

    // Methods
    public static void AddOrder(Order newOrder)
    {
        orders.Add(newOrder);
        Console.WriteLine($"Order {newOrder.OrderID} added for Customer {newOrder.CustomerID}.");
    }

    public static void RemoveOrder(int orderID)
    {
        var orderToRemove = orders.Find(order => order.OrderID == orderID);
        if (orderToRemove != null)
        {
            orders.Remove(orderToRemove);
            Console.WriteLine($"Order {orderID} has been removed.");
        }
        else
        {
            Console.WriteLine($"Order {orderID} not found.");
        }
    }

    public void AddItem(double itemPrice)
    {
        OrderTotal += itemPrice;
        Console.WriteLine($"Item added to Order {OrderID}. New total: {OrderTotal:C}");
    }

    public void RemoveItem(double itemPrice)
    {
        if (OrderTotal >= itemPrice)
        {
            OrderTotal -= itemPrice;
            Console.WriteLine($"Item removed from Order {OrderID}. New total: {OrderTotal:C}");
        }
        else
        {
            Console.WriteLine("Cannot remove item. Order total is less than item price.");
        }
    }

    public void Checkout()
    {
        OrderStatus = "Completed";
        Console.WriteLine($"Order {OrderID} has been checked out. Status: {OrderStatus}");
    }

    // Static method to view all orders
    public static void ViewAllOrders()
    {
        if (orders.Count > 0)
        {
            Console.WriteLine("All Orders:");
            foreach (var order in orders)
            {
                Console.WriteLine($"OrderID: {order.OrderID}, CustomerID: {order.CustomerID}, Total: {order.OrderTotal:C}, Status: {order.OrderStatus}");
            }
        }
        else
        {
            Console.WriteLine("No orders available.");
        }
    }
}
