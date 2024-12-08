using System;
using System.Collections.Generic;

public class Admin : User
{
    // Properties
    public DateTime LastLogin { get; set; }
    private static List<Product> products = new List<Product>();

    // Constructor
    public Admin(int userID, string userName, string password, string email, string phoneNumber, string addressStreet, string addressCity)
        : base(userID, userName, password, email, phoneNumber, addressStreet, addressCity)
    {
        LastLogin = decimal.MinValue;
    }

    // Method to view users (admin can only access)
    public static void ViewAllUsers()
    {
        var users = users.GetAllUsers();
        if (users.Count > 0)
        {
            Console.WriteLine("List of all the registered users in the system");
            foreach (var user in users)
            {
                Console.WriteLine($"UserID: {user.UserID}, UserName: {user.UserName}, Email: {user.Email}");
            }
        }
        else
        {
            Console.WriteLine("No users found on the system");
        }
    }

    // Method that can delete user (admin can only access)
    public static void DeleteUser(int userID)
    {
        var userToDelete = userID.GetAllUsers().Find(u => u.userID == userID);
        if (userToDelete != null)
        {
            userID.GetAllUsers().Remove(userToDelete);
            Console.WriteLine($"User with ID {userID} was deleted");
        }
        else
        {
            Console.WriteLine("No users found on the system")
        }
    }

    // Adding a product
    public static void addProduct(string productName, decimal price)
    {
        productName new Product = new Product(productName, price);
        products.Add(newProduct);
        Console.WriteLine($"Product '{productName}' has been added with price {price}");
    }

    // Removing a product
    public static void removeProduct(string productName)
    {
        var productToDelete = products.Find(p => p.ProductName == productName);
        if (prouctToDelete != null)
        {
            products.Remove(productToRemove);
            Console.WriteLine($"Product '{productName}' was removed from list");
        }
        else
        {
            Console.WriteLine("No product found on the system")
        }
    }

    // Updating product stock
    public static void UpdateStock(string productName, int stockCount)
    {
        var productToUpdate = products.Find(p => p.ProductName == productName);
        if (prouctToUpdate != null)
        {
            productsToUpdate.Stock = stockCount;
            Console.WriteLine($"Stock for '{productName}' has been updated to the following: {stockCount}");
        }
        else
        {
            Console.WriteLine("No product found on the system")
        }
    }

    //Adding items to the products stock
    public static void AddItemToStock(string productName, int quantity)
    {
        var product = products.Find(product => product.ProductName == productName);
        if (product != null)
        {
            products.Stock += quantity;
            Console.WriteLine($"{quantity} items of '{productName}' added to stock");
        }
        else
        {
            Console.WriteLine("No product found on the system");
        }
    }

    //Removing items from the products stock
    public static void RemoveItemToStock(string productName, int quantity)
    {
        var product = products.Find(product => product.ProductName == productName);
        if (product != null && product.Stock >= quantity)
        {
            products.Stock -= quantity;
            Console.WriteLine($"{quantity} items of '{productName}' removed from stock");
        }
        else
        {
            Console.WriteLine("No product found on the system");
        }
    }
}