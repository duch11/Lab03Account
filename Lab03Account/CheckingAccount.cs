using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Account
{
    class CheckingAccount : Account
    {
        private double overDraft;

        public CheckingAccount(int ac, string name, double balance, double overDraft) : base(ac, name, balance) {



        }

        new public bool withdraw(double amt)
        {
            if (amt <= balance + overDraft)
            {
                balance = balance - amt;
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
