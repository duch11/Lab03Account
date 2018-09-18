using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Account
{
    class Account
    {
        private int accNum;
        private string name;
        protected double balance;

        public Account(int ac, string name, double bal)
        {
            this.accNum = ac;
            this.name = name;
            this.balance = bal;
        }

        public bool deposit(double amt)
        {
            if (amt < 0)
            {
                return false;
            } else {
                balance = balance + amt;
                return true;
            }
        }

        public bool withdraw(double amt)
        {
            if (amt <= balance)
            {
                balance = balance - amt;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool transfer(Account a, double amt)
        {
            
            if (withdraw(amt))
            {
                if (a.deposit(amt))
                {
                    return true;
                }
                else
                {
                    deposit(amt);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        override
        public string ToString()
        {
            return accNum + " " + name+" " + balance;
        }

        public int getAccountNumber()
        {
            return accNum;
        }


    }
}
