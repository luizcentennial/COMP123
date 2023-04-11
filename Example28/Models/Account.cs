using System;
using System.Collections.Generic;

namespace Example28.Models {
	public class Account {
		public string AccountID { get; set; }
		public string AccountNumber { get; set; }
		public Customer Customer { get; set; }
		public AccountType Type { get; set; }
		public List<Transaction> Transactions { get; set; }
		public decimal Balance { 
			get {
				decimal total = 0;

				foreach (Transaction transaction in this.Transactions) {
					if (transaction.Type == TransactionType.Credit) {
						total += transaction.Value;
					}
					else {
						total -= transaction.Value;
					}
				}

				return total;
			}
		}

		public Account() {
			this.AccountID = Guid.NewGuid().ToString();
			this.Transactions = new List<Transaction>();
		}
	}
}
