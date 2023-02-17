using Example14.Models;
using System.IO;
using System.Xml.Serialization;

namespace Example14.Services {
	public static class ProductService {
		private static string s_root;
		private static XmlSerializer s_serializer;

		static ProductService() {
			s_root = @"C:\test\";
			s_serializer = new XmlSerializer(typeof(Product));
		}

		public static void Create(Product obj) {
			string filename = $"{obj.ProductGuid}.xml";

			using (Stream stream = new FileStream(s_root + filename, FileMode.Create)) {
				s_serializer.Serialize(stream, obj);
			}
		}

		public static Product[] Get() {
			string[] files = Directory.GetFiles(s_root, "*.xml");
			Product[] products = new Product[files.Length];

			for (int i = 0; i < products.Length; i++) {
				using (Stream stream = new FileStream(files[i], FileMode.Open)) {
					Product product = (Product)s_serializer.Deserialize(stream);

					products[i] = product;
				}
			}

			return products;
		}

		public static Product Get(string guid) {
			string filename = $"{guid}.xml";

			if (File.Exists(s_root + filename)) {
				using (Stream stream = new FileStream(s_root + filename, FileMode.Open)) {
					Product product = (Product)s_serializer.Deserialize(stream);

					return product;
				}
			}

			return null;
		}

		public static void Update(Product obj) {
			Delete(obj);
			Create(obj);
		}

		public static void Delete(Product obj) {
			string filename = $"{obj.ProductGuid}.xml";

			if (File.Exists(s_root + filename)) {
				File.Delete(s_root + filename);
			}
		}
	}
}
