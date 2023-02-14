using Example14.Models;
using Example14.Services;
using System;

namespace Example14 {
	class Program {
		static void Main(string[] args) {
			// XML SERIALIZATION:
			// A technique that can be used to represent data in a way that machines can easily understand.

			// Creating product:
			Product product = new Product("Guitar", "A very cool guitar.", 5399.99);
			ProductService.Create(product);

			// Loading a single product:
			Product parsed = ProductService.Get(product.ProductGuid);
			Console.WriteLine(parsed);

			// Loading all products:
			Product[] allProducts = ProductService.Get();

			// Updating a product:
			parsed.Price = 3999.99;
			ProductService.Update(parsed);

			// Deleting a product:
			ProductService.Delete(parsed);

			// Displaying products:
			foreach (Product p in allProducts) {
				Console.WriteLine(p);
			}
		}
	}
}
