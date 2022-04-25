using System;
using Proj22.Entities.Exceptions;
using Proj22.Entities;

namespace Proj22{
    class Program{
        static void Main(){
            try{
                System.Console.WriteLine("Enter the account data:");
                System.Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                System.Console.Write("Name of the holder: ");
                string holder = Console.ReadLine();
                System.Console.Write("Balance: ");
                double balance = double.Parse(Console.ReadLine());
                System.Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                System.Console.Write("\nWhat amount do u want to withdraw? ");
                double amount = double.Parse(Console.ReadLine());
                account.withdraw(amount);
            }
            catch(FormatException e){
                System.Console.WriteLine("Format error! " + e.Message);
            }
            catch(DomainException e){
                System.Console.WriteLine("Withdraw error! " + e.Message);
            }
            
        }
    }
}