using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpObjectIntro.Classes.Diary;
using CSharpObjectIntro.Classes.BankAccount;

namespace CSharpObjectIntro
{
    internal class OOPExercises
    {
        
        internal static void Run()
        {
            //UseDiary();
            UseBankAccount();
        }

        internal static void UseDiary()
        {
            // Create a new diary 
            Diary diary = new Diary("Bob Smith"); 
            Console.WriteLine(diary.Name);
            DateOnly eventDate1 = new DateOnly(2022, 10, 1);
            diary.AddEvent(new DateOnly(2022, 10, 1), 14, "Party", "Barnes");
            diary.AddEvent(new DateOnly(2022, 10, 1), 8, "School", "Barnes");
            Console.WriteLine(diary.CheckDiary(eventDate1));
            Console.WriteLine(diary.CheckMorningEvents(eventDate1));

            // Add some events to your diary

            // Now check how many events you have on a particular day

            // Implement a new method in the Diary class to return the number of morning events on a particular day
            // Call this method
        }

        internal static void UseBankAccount()
        {
            DateTime today = DateTime.Today;
            decimal amount = 10m;
            BankAccount bankAccount = new BankAccount(1000m, today, 200m);
            Console.WriteLine(bankAccount.balance);
            Console.WriteLine(bankAccount.WithdrawCash(10m));
            Console.WriteLine(bankAccount.DepositCash(20m));
            Console.WriteLine(bankAccount.WithdrawCash(290m));
            bankAccount.AccountTransaction(today, amount, "food", "tesco", "Card", "Food from tesco");
            
            // Implement your bank account class following the instructions in the BankAccount class

            // Write calling code from here
        }
    }
}

