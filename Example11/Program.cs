using Example11.Models;
using Example11.Services;
using System;

namespace Example11 {
	class Program {
		static void Main(string[] args) {
			var products = ProductService.Get();

			// Existing products.
			//DisplayProducts(products);

			// Adding new product.
			var product = new Product("Bike", "A very nice bike.", 500);
			ProductService.Create(product);

			// Retrieving all products.
			products = ProductService.Get();
			//DisplayProducts(products);

			// Retrieving a single product by guid.
			product = ProductService.Get(product.ProductGuid);
			//Console.WriteLine(product);

			// Updating product.
			product.Price = 299;
			ProductService.Update(product);

			products = ProductService.Get();
			//DisplayProducts(products);

			// Deleting a product.
			ProductService.Delete(product);

			products = ProductService.Get();
			DisplayProducts(products);
		}

		private static void DisplayProducts(Product[] products) {
			foreach (var p in products) {
				Console.WriteLine(p);
			}
		}
	}
}
