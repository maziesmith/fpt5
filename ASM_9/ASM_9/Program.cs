using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1, "Phatias", 1000);
            int choice = 0;
            Console.WriteLine("*********** WELCOME TO ATM BANKING ***********");
            while (true)
            {
                do
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("1. Get Cash");
                    Console.WriteLine("2. Deposit Cash");
                    Console.WriteLine("3. Deposit check");
                    Console.WriteLine("4. Balance statement");
                    Console.WriteLine("5. Transfer");
                    Console.WriteLine("6. Exit");
                    Console.Write("You choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 6)
                    {
                        Console.WriteLine("You have entered the wrong choice");
                    }
                } while (choice < 1 || choice > 6);
                int money;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Input the cash you want to get: ");
                        money = Convert.ToInt32(Console.ReadLine());
                        acc.GetCash = money;
                        break;

                    case 2:
                        Console.WriteLine("Input the cash you want to deposit: ");
                        money = Convert.ToInt32(Console.ReadLine());
                        acc.DepositCash = money;
                        break;

                    case 3:
                        Console.WriteLine("Input the check you want to deposit: ");
                        money = Convert.ToInt32(Console.ReadLine());
                        acc.DepositCheck = money;
                        break;

                    case 4:
                        Console.WriteLine($"The current balance of this account: {acc.BalanceStatement}");
                        break;

                    case 5:
                        Console.WriteLine("Input the amount that you want to transfer: ");
                        money = Convert.ToInt32(Console.ReadLine());
                        acc.Transfer = money;
                        break;

                    case 6:
                        Console.WriteLine("Thanks for using our ATM!");
                        return;
                }
            }
        }
    }
}
