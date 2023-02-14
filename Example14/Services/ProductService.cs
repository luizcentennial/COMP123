using Example14.Models;
using System.IO;
using System.Xml.Serialization;

namespace Example14.Services {
	public static class ProductService {
		private static string root;
		private static XmlSerializer serializer;

		static ProductService() {
			root = @"C:\test\";
			serializer = new XmlSerializer(typeof(Product));
		}

		public static void Create(Product obj) {
			using (Stream stream = new FileStream($"{root}{obj.ProductGuid}.xml", FileMode.Create)) {
				serializer.Serialize(stream, obj);
			}
		}

		public static Product[] Get() {
			string[] files = Directory.GetFiles(root, "*.xml");
			Product[] products = new Product[files.Length];

			for (int i = 0; i < products.Length; i++) {
				using (Stream stream = new FileStream(files[i], FileMode.Open)) {
					Product product = (Product)serializer.Deserialize(stream);

					products[i] = product;
				}
			}

			return products;
		}

		public static Product Get(string guid) {
			using (Stream stream = new FileStream($"{root}{guid}.xml", FileMode.Open)) {
				Product product = (Product)serializer.Deserialize(stream);

				return product;
			}
		}

		public static void Update(Product obj) {
			Delete(obj);
			Create(obj);
		}

		public static void Delete(Product obj) {
			string file = $"{root}{obj.ProductGuid}.xml";

			if (File.Exists(file)) {
				File.Delete(file);
			}
		}
	}
}
