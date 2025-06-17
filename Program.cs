class Program
{
    static void Main()
    {
        BankAccount acct = new BankAccount("Brian", 1000);
        acct.PrintStatement();

        acct.Deposit(500);
        acct.Withdraw(300);
        acct.PrintStatement();
    }
}
