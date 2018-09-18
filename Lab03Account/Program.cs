using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Account
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            double amount = 2.8d;
            Console.WriteLine("Doing a transfer of " + amount + "!");
            Account[] accounts = new Account[2];
            accounts[0] = new Account(1, "account one", 20.2);
            accounts[1] = new Account(2, "account two", 10f);
            foreach(Account a in accounts)
            {
                Console.WriteLine(a);
            }


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
