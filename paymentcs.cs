using System;

public class Payment
{
    // Properties
    public int PaymentID { get; set; }
    public int OrderID { get; set; } // Links to the associated order
    public string PaymentMethod { get; set; } // E.g., "Credit Card", "PayPal"
    public double PaymentAmount { get; set; }
    public string PaymentStatus { get; set; } // E.g., "Processed", "Failed"

    // Constructor
    public Payment(int paymentID, int orderID, string paymentMethod, double paymentAmount, string paymentStatus)
    {
        PaymentID = paymentID;
        OrderID = orderID;
        PaymentMethod = paymentMethod;
        PaymentAmount = paymentAmount;
        PaymentStatus = paymentStatus;
    }

    // Methods
    public void ProcessPayment()
    {
        if (PaymentAmount > 0)
        {
            PaymentStatus = "Processed";
            Console.WriteLine($"Payment of {PaymentAmount:C} for Order {OrderID} processed successfully via {PaymentMethod}.");
        }
        else
        {
            PaymentStatus = "Failed";
            Console.WriteLine($"Payment failed for Order {OrderID}. Invalid amount.");
        }
    }

    public void Refund()
    {
        if (PaymentStatus == "Processed")
        {
            PaymentStatus = "Refunded";
            Console.WriteLine($"Payment of {PaymentAmount:C} for Order {OrderID} has been refunded.");
        }
        else
        {
            Console.WriteLine("Refund cannot be processed. Current payment status: " + PaymentStatus);
        }
    }
}

