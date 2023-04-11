using System;

namespace Example28.Models {
	public class Address {
		public string AddressID { get; set; }
		public string AddressLine1 { get; set; }
		public string AddressLine2 { get; set; }
		public string City { get; set; }
		public string Province { get; set; }
		public string PostalCode { get; set; }
		public string Country { get => "Canada"; }

		public Address() {
			this.AddressID = Guid.NewGuid().ToString();
		}
	}
}
