using System;

namespace DoudExFeb7
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acct1 = new Account();
            acct1.Deposit(1000);
            Console.WriteLine($"{Account}|");
        }
    }
}
