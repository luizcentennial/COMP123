using Example14.Models;
using Example14.Services;
using System;

namespace Example14 {
	class Program {
		static void Main(string[] args) {
			// XML SERIALIZATION:
			// A technique that can be used to represent data in a way that machines can easily understand.
			Product product1 = new Product("Electric Guitar", "A very cool electric guitar.", 5399.99);
			Product product2 = new Product("Bass Guitar", "A very cool bass guitar.", 5399.99);

			// Creating a serialized Product instance:
			ProductService.Create(product1);
			ProductService.Create(product2);

			// Loading a single serialized Product instance:
			Product product = ProductService.Get(product2.ProductGuid);
			//Console.WriteLine(product);

			// Updating a serialized Product instance:
			product.Price = 3999.99;
			ProductService.Update(product);

			// Deleting a serialized Product instance:
			ProductService.Delete(product);

			// Loading all serialized Product instances:
			Product[] products = ProductService.Get();

			foreach (Product p in products) {
				Console.WriteLine(p);
			}
		}
	}
}
