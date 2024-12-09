using System;

public class Customer : User
{
    // Additional properties specific to Customer
    public string Status { get; set; } // Active or Inactive
    public string Role { get; set; } = "Customer"; // Default value set to "Customer"

    // Constructor to initialize Customer
    public Customer(int id, string userName, string password, string email, string phoneNumber, string addressStreet, string addressCity, string status)
        : base(id, userName, password, email, phoneNumber, addressStreet, addressCity)
    {
        Status = status;
    }

    // Overridden ToString method for displaying customer details
    public override string ToString()
    {
        return $"Customer ID: {ID}, Name: {UserName}, Status: {Status}, Role: {Role}, Email: {Email}, Address: {AddressStreet}, {AddressCity}";
    }
}