using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjectIntro.Classes.BankAccount
{
    public class BankAccount
    {
        public class transaction
        {
            public DateTime Date { get; private set; }
            public decimal Amount { get; private set;}
            public string Counterparty { get; set; }
            public string TransactionType { get; set; }
            public string Description { get; set; }
            public string Category { get; set; } 
            public transaction(DateTime date, decimal amount, string category, string counterparty, string transactionType, string description = "")
            {
                Date = date;
                Amount = amount;
                Category = category;
                Counterparty = counterparty;
                TransactionType = transactionType;
                Description = description;
            }
        }

        // As you complete each task make sure you test your code carefully
        // Choose some combination of manual testing, Debug.Assert and unit tests
        // Task One        
        // The bank account should have a balance property        
        // It should have a constructor that sets the initial balance (default zero) and the opening date (default today)
        // It should have methods to deposit and withdraw/make payments from the account. 
        public BankAccount(decimal Balance, DateTime Openingdate, decimal Limit)
        {
            balance = Balance;
            openingdate = Openingdate;
            limit = Limit;
        }
        public BankAccount()
        {
            balance = 0m;
            openingdate = DateTime.Today;
        }
        public decimal balance { get; private set; }
        public DateTime openingdate { get; private set; }
        public decimal limit { get; private set; }
        private List<transaction> transactionInfo = new List<transaction>();

        public decimal DepositCash(decimal newMoney)
        {
            balance = newMoney + balance;
            return balance;
        }
        public decimal WithdrawCash(decimal newMoney)
        {
            if (limit <= newMoney)
            {
                Console.WriteLine($"{newMoney} is greater than your set limit (£{limit}). Enter a value below your limit");
                return balance;
            }
            else
            {
                balance = balance - newMoney;
                return balance;
            }
        }

        // Task Two
        // Give the option to set an overdraft limit
        // Do not allow a withdrawal/payment if the overdraft limit is exceeded. You could return false or throw an exception.
        public void SetLimit(decimal Limit)
        {
            Console.WriteLine($"Your withdrawal Limit is {Limit}");
            Limit = limit;
        }
        // Task Three
        // Create a new class called AccountTransaction.
        // It could contain properties such as
        // date, amount, category, counterparty, transactionType, description (optional)
        // e.g 26/09/2022 16:45, -300, Groceries, Waitrose, Card, Weekly shop
        //     27/09/2022 17:40, 200, Gift, Bob Smith, Cheque, Birthday present
        // You might wish to use enums for category and transactionType
        // Amend your bank account to contain a list of transactions
        // The methods for  deposit and withdraw/make payments should be amended to add transactions
        public void AccountTransaction(DateTime date, decimal amount, string category, string counterparty, string transactionType, string description = "")
        {
            var information = new transaction(date, amount, category, counterparty, transactionType, description);
            transactionInfo.Add(information);
            Console.WriteLine(string.Join (" ", transactionInfo));
        }
        // Task Four
        // Now add some new methods to your account
        // - See what the balance was at a previous date
        // - See how much money was spent in a given time period
        // - See how much money was spent in different categories

        // Extension
        // Work out how much interest is payable on your account
        // For the moment make up the interest rates, though later we could look at loading them from a website
        // The interest should be added as transactions to your account





    }
}
