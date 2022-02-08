using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudExFeb7 {
    public class Account {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }

        public bool Deposit(decimal Amount) {
            if(Amount <= 0) {
                throw new Exception("Amount must be positive.");
            }
            Balance += Amount;
            return true;
        }
        public bool Withdrawl(decimal Amount) {
            if(Amount <= 0) {
                throw new Exception("Amount must be positive.");
            }
            if(Amount > Balance) {
                throw new Exception("Insuficient Funds!");
            }
            Balance -= Amount;
            return true;
        }
        
    }
}
