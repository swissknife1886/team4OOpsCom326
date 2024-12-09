using System;

public class Shipment
{
    // Private variables
    private int shipmentId;
    private string orderID;
    private string shipmentAddress;
    private DateTime shipmentDate;
    private string status;


    // Constructor
    public Shipment(int shipmentId, string orderID, string shipmentAddress, DateTime shipmentDate, string status)
    {
        this.shipmentId = shipmentId;
        this.orderID = orderID;
        this.shipmentAddress = shipmentAddress;
        this.shipmentDate = shipmentDate;
        this.status = status;
    }

    // Public properties 
    public int ShipmentId
    {
        get { return shipmentId; }
        set { shipmentId = value; }
    }

    public string OrderID
    {
        get { return orderID; }
        set { orderID = value; }
    }
    public string ShipmentAddress
    {
        get { return shipmentAddress; }
        set { shipmentAddress = value; }
    }

    public DateTime ShipmentDate
    {
        get { return shipmentDate; }
        set { shipmentDate = value; }
    }
    public string Status
    {
        get { return status; }
        set { status = value; }
    }



    public void createShipment()
    {
        Console.WriteLine($"Shipping order {ShipmentId} to {ShipmentAddress} on {shipmentDate.ToShortDateString()}...");
    }

    public void trackShipment()
    {
        Console.WriteLine($"Shipping order: {ShipmentId}, Status: {Status}");
    }
}
