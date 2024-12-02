using System;

public class User
{
	public User()
	{
	public int UserID { get; set; }
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Email { get; set; }
	public string PhoneNumber { get; set; }
	public string AddressStreet { get; set; }
	public string AddressCity { get; set; }

	public string void Register(string UserName, string Password, string Email, string PhoneNumber, string AddressStreet, string AddressCity)
	{
		User newUser = new User();
		{
			UserID = users.Count + 1,
			UserName = UserName,
			Password = Password,
			Email = Email,
			PhoneNumber = PhoneNumber,
			AddressStreet = AddressStreet,
			AddressCity = AddressCity,
		};

		users.Add(newUser);
		Console.WriteLine("Registration Authorised");
	}

	public static User Login(string UserName, string Password)
	{
		foreach (var in users)
		{
			if (user.UserName == UserName && User.Password == Password)
			{
				Console.WriteLine("Login Successful");
				return user;
			}
		}
		Console.WriteLine("Invalid Username or Password, Please Try Again")
		return null;
	}

	public static void ForgotPassword(string email)
	{
		foreach (var users in users)
		{
			if (users.Email == email)
			{
				Console.WriteLine($"Password reset link is being sent to {email}");
				return;
			}
		}
		Console.WriteLine("Your Email is not in the database");
	}
}