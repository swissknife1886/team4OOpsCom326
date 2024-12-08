using System;
using System.Collections.Generic;

public class Category
{
    // Properties
    public int CategoryID { get; set; } // Unique identifier for the category
    public string CategoryName { get; set; } // Name of the category
    public string Description { get; set; } // Description of the category

    // Static list to store all categories
    private static List<Category> categories = new List<Category>();

    // Constructor
    public Category(int categoryID, string categoryName, string description)
    {
        CategoryID = categoryID;
        CategoryName = categoryName;
        Description = description;
    }

    // Method to add a new category
    public static void AddCategory(Category newCategory)
    {
        categories.Add(newCategory);
        Console.WriteLine($"Category '{newCategory.CategoryName}' has been added successfully.");
    }

    // Method to remove a category
    public static void RemoveCategory(int categoryID)
    {
        var categoryToRemove = categories.Find(c => c.CategoryID == categoryID);
        if (categoryToRemove != null)
        {
            categories.Remove(categoryToRemove);
            Console.WriteLine($"Category '{categoryToRemove.CategoryName}' has been removed.");
        }
        else
        {
            Console.WriteLine($"Category with ID {categoryID} not found.");
        }
    }

    // Method to update a category
    public static void UpdateCategory(int categoryID, string categoryName, string description)
    {
        var categoryToUpdate = categories.Find(c => c.CategoryID == categoryID);
        if (categoryToUpdate != null)
        {
            categoryToUpdate.CategoryName = categoryName;
            categoryToUpdate.Description = description;
            Console.WriteLine($"Category '{categoryID}' has been updated successfully.");
        }
        else
        {
            Console.WriteLine($"Category with ID {categoryID} not found.");
        }
    }

    // Method to view all categories
    public static void ViewAllCategories()
    {
        if (categories.Count > 0)
        {
            Console.WriteLine("List of all categories:");
            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryID}, Name: {category.CategoryName}, Description: {category.Description}");
            }
        }
        else
        {
            Console.WriteLine("No categories available.");
        }
    }

    // Method to search for a category by name
    public static void SearchCategoryByName(string categoryName)
    {
        var matchingCategories = categories.FindAll(c => c.CategoryName.Contains(categoryName, StringComparison.OrdinalIgnoreCase));
        if (matchingCategories.Count > 0)
        {
            Console.WriteLine("Matching categories:");
            foreach (var category in matchingCategories)
            {
                Console.WriteLine($"ID: {category.CategoryID}, Name: {category.CategoryName}, Description: {category.Description}");
            }
        }
        else
        {
            Console.WriteLine("No matching categories found.");
        }
    }
}
