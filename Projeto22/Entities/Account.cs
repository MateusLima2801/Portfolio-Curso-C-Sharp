using Proj22.Entities.Exceptions;

namespace Proj22.Entities{
    class Account{
        public int Number {get; set; }
        public string Holder {get; set;}
        public double Balance {get; set;}
        public double WithdrawLimit {get; set;}

        public Account(){}

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void deposit(double amount){
            Balance += amount;
        }

        public void withdraw(double amount){
            if(amount >= Balance){
                throw new DomainException("Insufficient balance.");
            }
            else if(amount >WithdrawLimit){
                throw new DomainException("Value beyond the available withdraw limit.");
            }
            else Balance -= amount;
        }
        
        public override string ToString()
        {
            return Number +
             " - " +
              Holder +
               " - " +
               Balance +
               "- ("
               +WithdrawLimit +")"
            ;
        }
    }
}