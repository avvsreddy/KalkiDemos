using ProductsManagementConsoleApp.DataLayer;
using ProductsManagementConsoleApp.Entities;

namespace ProductsManagementConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UI
            // User Story: I As a user, I want to be able to manage products in a console application, so that I can perform CRUD operations on products.
            // User Story: I As a user, I want to be able to save a product, so that I can preserv the products data


            // Step 1: Install EF Core - DONE
            // Step 2: Create a Product class with properties: Id, Name, Description, Price, Brand, Category, Country - DONE
            // Step 3: Configure the database and map the Product class to a database table using EF Core - DONE
            // Step 4: Data Migration - Generate the database schema based on the Product class and apply the migration to create the database table - DONE

            // Step 5: Implement CRUD operations for the Product class using EF Core

            // Update
            // get the product to update
            ProductsDbContext db = new ProductsDbContext();
            Product productToUpdate = db.Products.Find(2); // Assuming the product with ID 2 exists
            if (productToUpdate != null) 
            {
                productToUpdate.Name = "I Phone 15 Pro Max";
                productToUpdate.Price = 88888;
                db.Products.Update(productToUpdate); // use this in disconnected scenario, otherwise it is not required
                db.SaveChanges();
            }
            else 
            {
                Console.WriteLine("Product Not Found");
            }


        }

        private static void Delete()
        {
            // How to Delete
            // get the product to delete
            ProductsDbContext db = new ProductsDbContext();
            Product productToDelete = db.Products.Find(1); // Assuming the product with ID 1 exists
            if (productToDelete != null)
            {
                db.Products.Remove(productToDelete);
                db.SaveChanges();
                Console.WriteLine("Product deleted");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        private static void Add()
        {
            // Insert a new product
            //Product p1 = new Product {Name = "I Phone 16 Pro", Description="Costliest Product", Price= 99999 };
            //Product p2 = new Product { Name = "I Phone 15", Description = "Costliest Product", Price = 67000 };
            //Product p3 = new Product { Name = "Galaxy S20", Description = "Cool Product", Price = 45000 };
            //Product p4 = new Product { Name = "Oppo Plus", Description = "Smart Product", Price = 67000 };
            //Product p5 = new Product { Name = "I Phone 16 Plus", Description = "Costliest Product", Price = 66666 };

            Product p6 = new Product { Name = "I Phone New 16 Plus", Description = "Costliest Product", Price = 66666 };
            ProductsDbContext db = new ProductsDbContext();
            //db.Products.Add(p1);
            //db.Products.Add(p2);
            //db.Products.Add(p3);
            //db.Products.Add(p4);
            //db.Products.Add(p5);
            db.Products.Add(p6);
            //db.Products.AddRange(p1,p2, p3, p4, p5);
            db.SaveChanges();
            Console.WriteLine("Product Saved....");
        }
    }
}
