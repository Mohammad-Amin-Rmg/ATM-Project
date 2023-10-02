using System;
using System.Collections.Generic;
using System.Linq;
namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("Please choose from one of the following options...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
            }

            void deposit(CardHolder depositOfUser)
            {
                Console.WriteLine("How much $$ would you like to deposit? ");
                double depositMoney = double.Parse(Console.ReadLine());
                depositOfUser.setBalance(depositOfUser.getBalance() + depositMoney);
                Console.WriteLine("Thank you for your $$. Your new balance is: " + depositOfUser.getBalance());
            }

            void withdraw(CardHolder withdrawOfUser)
            {
                Console.WriteLine("How much $$ would you like to withdraw? ");
                double withdrawal = double.Parse(Console.ReadLine());

                //Check if the user has enough money
                if (withdrawOfUser.getBalance() > withdrawal)
                {
                    withdrawOfUser.setBalance(withdrawOfUser.getBalance() - withdrawal);
                    Console.WriteLine("Yo're good to go! Thank you :)");
                }
                else
                {
                    Console.WriteLine("Insufficient balance :(");
                }
            }

            void balance(CardHolder balanceOfUser)
            {
                Console.WriteLine("Current balance: " + balanceOfUser.getBalance());
            }

            List<CardHolder> cardHolders = new List<CardHolder>();
            cardHolders.Add(new CardHolder("5647895236521457", "alex", "diviu", 50.350, 1235));
            cardHolders.Add(new CardHolder("1425369685741236", "mik", "gomez", 132.250, 4563));
            cardHolders.Add(new CardHolder("7898456532124569", "alice", "john", 40.000, 9632));
            cardHolders.Add(new CardHolder("9871234567899875", "sara", "parker", 98.500, 1968));

            //Promt user
            Console.WriteLine("Welcome to SimpleATM");
            Console.WriteLine("Please etner your debit card: ");
            string debitCardNumber = "";
            CardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNumber = Console.ReadLine();
                    //Check against our db
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNumber == debitCardNumber);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Card not recognized. Please try again"); }
                }
                catch { Console.WriteLine("Card not recognized. Please try again"); }
            }

            Console.WriteLine("Please enter your pin: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.getPin() == userPin) { break; }
                    else { Console.WriteLine("Incorrect pin. Please try again"); }
                }
                catch { Console.WriteLine("Incorrect pin. Please try again"); }
            }

            Console.WriteLine("Welcome " + currentUser.getFirstName() + ":)");
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { deposit(currentUser); }
                else if (option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
            }
            while (option != 4);
            Console.WriteLine("Thank you! Have a nice day :)");

        }
    }
}
