using Example11.Models;

namespace Example11.Services {
	public static class ProductService {
		private static Product[] s_products;

		static ProductService() {
			s_products = new Product[] {
				new Product("Electric Guitar", "A very nice electric guitar.", 12999),
				new Product("Acoustic Guitar", "A very nice acoustic guitar.", 8999),
				new Product("Keyboards", "A very nice keyboards.", 2999),
				new Product("Drum set", "A very nice drums set.", 7999),
				new Product("Bass Guitar", "A very nice bass guitar.", 4999),
			};
		}

		public static void Create(Product obj) {
			// Logic to store a product in database.
			Product[] newProducts = new Product[s_products.Length + 1];

			s_products.CopyTo(newProducts, 0);
			newProducts[newProducts.Length - 1] = obj;

			s_products = newProducts;
		}

		public static Product[] Get() {
			// Logic to retrieve all products from database.
			return s_products;
		}

		public static Product Get(string guid) {
			// Logic to retrieve a product from database.
			foreach (var product in s_products) {
				if (product.ProductGuid == guid) {
					return product;
				}
			}

			return null;
		}

		public static void Update(Product obj) {
			// Logic to update a product in database.
			Delete(obj);
			Create(obj);
		}

		public static void Delete(Product obj) {
			// Logic to delete a product from database.
			Product[] newArray = new Product[s_products.Length - 1];
			int index = 0;

			foreach (var product in s_products) {
				if (product.ProductGuid != obj.ProductGuid) {
					newArray[index] = product;
					index++;
				}
			}

			s_products = newArray;
		}
	}
}
