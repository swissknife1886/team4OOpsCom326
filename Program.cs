using System;

public class Program
{
    public static void Main(string[] args)
    {
        MainMenu();
    }

    static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Manage Products");
            Console.WriteLine("2. Manage Categories");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ProductMenu();
                    break;
                case "2":
                    CategoryMenu();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ProductMenu()
    {
        while (true)
        {
            Console.WriteLine("\nProduct Menu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. View All Products");
            Console.WriteLine("5. Search Product by Name");
            Console.WriteLine("6. Back to Main Menu");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Product ID: ");
                    int productId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Product Name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter Product Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Product.AddProduct(new Product(productId, productName, price));
                    break;
                case "2":
                    Console.Write("Enter Product ID to remove: ");
                    int removeProductId = int.Parse(Console.ReadLine());
                    Product.RemoveProduct(removeProductId);
                    break;
                case "3":
                    Console.Write("Enter Product ID to update: ");
                    int updateProductId = int.Parse(Console.ReadLine());
                    Console.Write("Enter new Product Name: ");
                    string newProductName = Console.ReadLine();
                    Console.Write("Enter new Product Price: ");
                    decimal newPrice = decimal.Parse(Console.ReadLine());
                    Product.UpdateProduct(updateProductId, newProductName, newPrice);
                    break;
                case "4":
                    Product.ViewAllProducts();
                    break;
                case "5":
                    Console.Write("Enter Product Name to search: ");
                    string searchProductName = Console.ReadLine();
                    Product.SearchProductByName(searchProductName);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CategoryMenu()
    {
        while (true)
        {
            Console.WriteLine("\nCategory Menu:");
            Console.WriteLine("1. Add Category");
            Console.WriteLine("2. Remove Category");
            Console.WriteLine("3. Update Category");
            Console.WriteLine("4. View All Categories");
            Console.WriteLine("5. Search Category by Name");
            Console.WriteLine("6. Back to Main Menu");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Category ID: ");
                    int categoryId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Category Name: ");
                    string categoryName = Console.ReadLine();
                    Console.Write("Enter Category Description: ");
                    string description = Console.ReadLine();
                    Category.AddCategory(new Category(categoryId, categoryName, description));
                    break;
                case "2":
                    Console.Write("Enter Category ID to remove: ");
                    int removeCategoryId = int.Parse(Console.ReadLine());
                    Category.RemoveCategory(removeCategoryId);
                    break;
                case "3":
                    Console.Write("Enter Category ID to update: ");
                    int updateCategoryId = int.Parse(Console.ReadLine());
                    Console.Write("Enter new Category Name: ");
                    string newCategoryName = Console.ReadLine();
                    Console.Write("Enter new Category Description: ");
                    string newDescription = Console.ReadLine();
                    Category.UpdateCategory(updateCategoryId, newCategoryName, newDescription);
                    break;
                case "4":
                    Category.ViewAllCategories();
                    break;
                case "5":
                    Console.Write("Enter Category Name to search: ");
                    string searchCategoryName = Console.ReadLine();
                    Category.SearchCategoryByName(searchCategoryName);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
