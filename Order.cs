using System;

public class Order
{
    // Private variables
    private int orderId;
    private double orderAmount;

    // Constructor
    public Order(int orderId, double orderAmount)
    {
        this.orderId = orderId;
        this.orderAmount = orderAmount;
    }

    // Public properties 
    public int OrderId
    {
        get { return orderId; }
        set { orderId = value; }
    }


    public double OrderAmount
    {
        get { return orderAmount; }
        set { orderAmount = value; }
    }


   
    public void checkOut()
    {
        Console.WriteLine($"OrderID: {OrderId}, Your total is: {OrderAmount}. Please proceed to payment ");
    }
}