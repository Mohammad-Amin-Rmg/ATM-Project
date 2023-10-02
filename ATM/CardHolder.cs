using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class CardHolder
    {
        public string cardNumber;
        public string firstName;
        public string lastName;
        public double balance;
        public int pin;

        public CardHolder(string cardNumber, string firstName, string lastName, double balance, int pin)
        {
            this.cardNumber = cardNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
            this.pin = pin;
        }

        public string getCardNumber()
        {
            return cardNumber;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public int getPin()
        {
            return pin;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setCardNumber(string newCardNumber)
        {
            cardNumber = newCardNumber;
        }

        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }
    }
}
