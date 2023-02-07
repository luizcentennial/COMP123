using System;

namespace Example11.Models {
	public class Product {
		private double _price;

		public string ProductGuid { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { 
			get {
				return this._price;
			}
			set {
				if (value >= 0)
					this._price = value;
				else
					throw new Exception($"Value '{value}' not accepted. Price cannot be less than zero.");
			}
		}

		public Product() {
			this.ProductGuid = Guid.NewGuid().ToString();
		}

		public Product(string name, string description) : this() {
			this.Name = name;
			this.Description = description;
		}

		public Product(string name, string description, double price) : this(name, description) {
			this.Price = price;
		}

		public override string ToString() {
			return $"Product ID: {this.ProductGuid} \n" +
				   $"Name: {this.Name} \n" +
				   $"Description: {this.Description} \n" +
				   $"Price: {this.Price:C} \n";
		}
	}
}
