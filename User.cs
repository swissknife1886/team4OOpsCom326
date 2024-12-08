using System;
using System.Collections.Generic;

public class User
{
    public int UserID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string AddressStreet { get; set; }
    public string AddressCity { get; set; }

    //Constructor
    public User(int userID, string userName, string password, string email, string phoneNumber, string addressStreet, string addressCity)
    {
        UserID = userID;
        UserName = userName;
        Password = password;
        Email = email;
        PhoneNumber = phoneNumber;
        AddressStreet = addressStreet;
        AddressCity = addressCity;

    }

    //Getting the List Of The User from - Program.cs
    private static List<User> users = new List<User>();

    //Method to register a new user
    public static void Register(string userName, string password, string email, string phoneNumber, string addressStreet, string addressCity)
    {
        user NewUser = new User(users.Count + 1, userName, password, email, phoneNumber, addressStreet, addressCity)

    //Adding in user to the list
    users.Add(NewUser);
        Console.WriteLine("Registration Complete")
    }

    //Login that will authenticate the user
    public static User Login(string UserName, string password)
    {
        foreach (var user in users)
        {
            if (user.UserName == UserName && user.Password == password)
            {
                Console.WriteLine("Login Successful");
                return user;
            }
        }
        Console.WriteLine("Username & Password is incorrect, please try again");
        return null;
    }

    public static void ForgotPassword(string email)
    {
        foreach (var user in users)
        {
            if (user.Email == email)
            {
                Console.WriteLine($" A Password Link is being sent to {email}");
                return;
            }
        }
        Console.WriteLine("We couldn't find your password in the existing database");
    }

    //Method to obtain all users (for admin only)
    public static List<User> GetAllUsers()
    {
        return users;
    }

    //Method to delete a user (for admin only)
    public static void DeleteUser(int userID)
    {
        var usertoDelete = users.Find(u = > u.UserID == userID);
        if (usertoDelete != null)
        {
            users.Remove(usertoDelete);
            Console.WriteLine($"This user {userID} was deleted");
        }
        else
        {
            Console.WriteLine("User not found on the system");
        }
    }
}


