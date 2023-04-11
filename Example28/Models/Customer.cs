using System;

namespace Example28.Models {
	public class Customer {
		public string CustomerID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public Address Address { get; set; }

		public Customer() {
			this.CustomerID = Guid.NewGuid().ToString();
		}

		public override string ToString() {
			return $"{this.FirstName} {this.LastName}";
		}
	}
}
