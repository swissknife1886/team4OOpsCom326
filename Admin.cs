using System;

public class Admin : User
{
	public DateTime LastLogin { get; set; }

	private static List<Product> products = new List<Product>();

	public void AddProduct(string name, decimal price, int stock)
	{
		Product newProduct = new Product
		{
			ProductID = products.count + 1,
			Name = name,
			Price = price,
			Stock = stock
		};

		products.Add(newProduct);
		Console.WriteLine("Product has been added successfully!");
	}

	public void RemoveProduct(int productId)
	{
		var product = products(p => p.ProductID == productId);
		if (product != null)
		{
			product.Remove(product);
			Console.WriteLine("Product has been Removed");

		}
		else

			Console.WriteLine("Product has not been found");
		}
	}
	
	public void UpdateStock(int productId, int newStock)
	{
	var product = products.Find(product => product.ProductID == productId);
	if (product != null)
	{
		product.Stock = newStock;
		Console.WriteLine("Product stock updated");
	}
	else
	{
		Console.WriteLine("Product was not updated");
		}
	}		
	
	public void AddItem(int orderId, int productId, int quantity)
	{
		Console.WriteLine($"Item (ProductID: {productId}) added to order (OrderID: {orderId} with quantity: {quantity}");
	}

	public void RemoveItem(int orderId, int productId)
	{
	Console.WriteLine($"Item (ProductID: {productId}) removed from order (OrderID: {orderId}");
	}
}