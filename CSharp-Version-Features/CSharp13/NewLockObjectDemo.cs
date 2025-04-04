using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp13
{
    /// <summary>
    /// Demonstrates a real-life example where the lock object is needed to prevent race conditions
    /// while modifying the bank account balance.
    /// </summary>
    public class NewLockObjectDemo
    {
        private static Lock _lock = new Lock(); // Lock object to synchronize access to the bank account

        public static async Task Run()
        {
            Console.WriteLine("=== Bank Account System Demo ===");

            // Create a bank account with an initial balance
            var bankAccount = new BankAccount(1000); // Starting balance is 1000

            // Simulate multiple deposits and withdrawals from different tasks
            var tasks = new List<Task>
            {
                Task.Run(() => PerformTransaction(bankAccount, "Deposit", 500)),
                Task.Run(() => PerformTransaction(bankAccount, "Withdraw", 200)),
                Task.Run(() => PerformTransaction(bankAccount, "Deposit", 300)),
                Task.Run(() => PerformTransaction(bankAccount, "Withdraw", 400))
            };

            // Wait for all tasks to complete
            await Task.WhenAll(tasks);

            // Final account balance
            Console.WriteLine($"\nFinal Account Balance: {bankAccount.Balance}");
        }

        /// <summary>
        /// Simulates a transaction (deposit or withdraw) on a bank account.
        /// </summary>
        /// <param name="account">The bank account object.</param>
        /// <param name="transactionType">The type of transaction (Deposit or Withdraw).</param>
        /// <param name="amount">The amount to deposit or withdraw.</param>
        public static async Task PerformTransaction(BankAccount account, string transactionType, decimal amount)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"{transactionType} of {amount:C} - Thread ID: {threadId} - Waiting for lock...");

            // Use the lock object to synchronize access to the account balance
            lock (_lock)
            {
                Console.WriteLine($"{transactionType} of {amount:C} - Thread ID: {threadId} - Entered the lock.");

                // Perform the transaction (deposit or withdraw)
                if (transactionType == "Deposit")
                {
                    account.Deposit(amount);
                }
                else if (transactionType == "Withdraw")
                {
                    account.Withdraw(amount);
                }

                Console.WriteLine($"{transactionType} of {amount:C} - Thread ID: {threadId} - Exiting the lock.");
            }

            // Simulate some async work outside of the lock
            await Task.Delay(100); // Simulate additional work after the transaction is done
        }
    }

    /// <summary>
    /// Represents a bank account with a balance.
    /// </summary>
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        /// <summary>
        /// Gets the current balance of the bank account.
        /// </summary>
        public decimal Balance => _balance;

        /// <summary>
        /// Deposits a specified amount into the bank account.
        /// </summary>
        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");
            _balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {_balance:C}");
        }

        /// <summary>
        /// Withdraws a specified amount from the bank account.
        /// </summary>
        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be positive.");
            if (_balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds to withdraw {amount:C}. Current balance: {_balance:C}");
            }
        }
    }

  
}
