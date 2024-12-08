using System;
using System.Collections.Generic;

public class Product
{
    // Properties
    public int ProductID { get; set; } // Unique identifier for the product
    public string ProductName { get; set; } // Name of the product
    public decimal Price { get; set; } // Price of the product
    public int Stock { get; set; } // Stock available for the product
    public string Category { get; set; } // Product category
    public string Description { get; set; } // Product description

    // Static list to store all products
    private static List<Product> products = new List<Product>();

    // Constructor
    public Product(int productID, string productName, decimal price, int stock, string category, string description)
    {
        ProductID = productID;
        ProductName = productName;
        Price = price;
        Stock = stock;
        Category = category;
        Description = description;
    }

    // Method to add a new product
    public static void AddProduct(Product newProduct)
    {
        products.Add(newProduct);
        Console.WriteLine($"Product '{newProduct.ProductName}' has been added successfully.");
    }

    // Method to remove a product
    public static void RemoveProduct(int productID)
    {
        var productToRemove = products.Find(p => p.ProductID == productID);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            Console.WriteLine($"Product '{productToRemove.ProductName}' has been removed.");
        }
        else
        {
            Console.WriteLine($"Product with ID {productID} not found.");
        }
    }

    // Method to update the details of a product
    public static void UpdateProduct(int productID, string productName, decimal price, int stock, string category, string description)
    {
        var productToUpdate = products.Find(p => p.ProductID == productID);
        if (productToUpdate != null)
        {
            productToUpdate.ProductName = productName;
            productToUpdate.Price = price;
            productToUpdate.Stock = stock;
            productToUpdate.Category = category;
            productToUpdate.Description = description;
            Console.WriteLine($"Product '{productID}' has been updated successfully.");
        }
        else
        {
            Console.WriteLine($"Product with ID {productID} not found.");
        }
    }

    // Method to view all products
    public static void ViewAllProducts()
    {
        if (products.Count > 0)
        {
            Console.WriteLine("List of all products:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price:C}, Stock: {product.Stock}, Category: {product.Category}, Description: {product.Description}");
            }
        }
        else
        {
            Console.WriteLine("No products available.");
        }
    }

    // Method to search for a product by name
    public static void SearchProductByName(string productName)
    {
        var matchingProducts = products.FindAll(p => p.ProductName.Contains(productName, StringComparison.OrdinalIgnoreCase));
        if (matchingProducts.Count > 0)
        {
            Console.WriteLine("Matching products:");
            foreach (var product in matchingProducts)
            {
                Console.WriteLine($"ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price:C}, Stock: {product.Stock}");
            }
        }
        else
        {
            Console.WriteLine("No matching products found.");
        }
    }

    // Method to check product stock
    public static void CheckStock(int productID)
    {
        var product = products.Find(p => p.ProductID == productID);
        if (product != null)
        {
            Console.WriteLine($"Product '{product.ProductName}' has {product.Stock} items in stock.");
        }
        else
        {
            Console.WriteLine($"Product with ID {productID} not found.");
        }
    }

    // Method to add stock to a product
    public static void AddStock(int productID, int quantity)
    {
        var product = products.Find(p => p.ProductID == productID);
        if (product != null)
        {
            product.Stock += quantity;
            Console.WriteLine($"Added {quantity} items to '{product.ProductName}'. New stock: {product.Stock}.");
        }
        else
        {
            Console.WriteLine($"Product with ID {productID} not found.");
        }
    }

    // Method to reduce stock of a product
    public static void ReduceStock(int productID, int quantity)
    {
        var product = products.Find(p => p.ProductID == productID);
        if (product != null)
        {
            if (product.Stock >= quantity)
            {
                product.Stock -= quantity;
                Console.WriteLine($"Removed {quantity} items from '{product.ProductName}'. New stock: {product.Stock}.");
            }
            else
            {
                Console.WriteLine($"Insufficient stock for '{product.ProductName}'. Current stock: {product.Stock}.");
            }
        }
        else
        {
            Console.WriteLine($"Product with ID {productID} not found.");
        }
    }
}
