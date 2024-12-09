using System;

public class Customer : User
{
    
    public string Status { get; set; } 
    public string Role { get; set; } = "Customer"; 

    
    public Customer(int id, string userName, string password, string email, string phoneNumber, string addressStreet, string addressCity, string status)
        : base(id, userName, password, email, phoneNumber, addressStreet, addressCity)
    {
        Status = status;
    }

    
    public override string ToString()
    {
        return $"Customer ID: {ID}, Name: {UserName}, Status: {Status}, Role: {Role}, Email: {Email}, Address: {AddressStreet}, {AddressCity}";
    }
}