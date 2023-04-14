using System;

namespace Example28.Models {
	public class Transaction {
		private decimal _value;

		public string TransactionID { get; set; }
		//public Account Account { get; set; }
		public DateTime ProcessedOn { get; set; }
		public TransactionType Type { get; set; }
		public decimal Value { 
			get {
				return this._value;
			}
			set {
				if (value > 0) {
					this._value = value;
				}
				else {
					throw new Exception("Transaction value cannot be zero or negative.");
				}
			}
		}

		public Transaction() {
			this.TransactionID = Guid.NewGuid().ToString();
			this.ProcessedOn = DateTime.Now;
		}

		public enum TransactionType {
			Debit,
			Credit
		}
	}
}
