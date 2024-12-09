using System;
using System.Collections.Generic;

public class ShoppingBasket
{
    
    public int CustomerID { get; set; }
    public List<(int ProductID, int Quantity)> ProductList { get; set; } = new List<(int, int)>();

    
    public ShoppingBasket(int customerID)
    {
        CustomerID = customerID;
    }

    
    public void AddItem(int productID, int quantity)
    {
        ProductList.Add((productID, quantity));
        Console.WriteLine($"Product {productID} added with quantity {quantity}.");
    }

    
    public void RemoveItem(int productID)
    {
        var item = ProductList.Find(p => p.ProductID == productID);
        if (item != default)
        {
            ProductList.Remove(item);
            Console.WriteLine($"Product {productID} removed from the basket.");
        }
        else
        {
            Console.WriteLine($"Product {productID} not found in the basket.");
        }
    }

    
    public void ViewCart()
    {
        Console.WriteLine("Shopping Basket:");
        foreach (var item in ProductList)
        {
            Console.WriteLine($"Product ID: {item.ProductID}, Quantity: {item.Quantity}");
        }
    }

    
    public void ClearCart()
    {
        ProductList.Clear();
        Console.WriteLine("Shopping basket cleared.");
    }
}