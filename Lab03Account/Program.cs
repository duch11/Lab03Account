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

            AccountManager manager = new AccountManager(12, 10);
            Console.WriteLine(manager);
            Console.ReadKey();
            Console.Clear();
            manager.addAccount("Trying", 20.2);
            Console.WriteLine(manager);
            Console.ReadKey();
            Console.Clear();
            manager.deposit(1, 20);
            Console.WriteLine(manager);
            Console.ReadKey();
            Console.Clear();
            manager.deposit(2, 300);
            Console.WriteLine(manager);
            Console.ReadKey();
            Console.Clear();
            manager.withdraw(2, 50);
            Console.WriteLine(manager);
            Console.ReadKey();
            Console.Clear();
            manager.transfer(2, 1, 300);
            Console.WriteLine(manager);
            Console.ReadKey();
            Console.Clear();
            manager.transfer(2, 1, 200);
            Console.WriteLine(manager);
            Console.ReadKey();
            Console.Clear();

            //MAKE CHECKING ACCOUNT AND USE OVERRIDDEN WITHDRAW METHOD!!
            Console.ReadKey();
        }
    }
}
