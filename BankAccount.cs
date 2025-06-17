public class BankAccount
{
   public string Owner { get; }
   public decimal Balance { get; private set; }
   public BankAccount(string owner, decimal initialBalance)
   {
       Owner = owner;
       Balance = initialBalance;
   }
   public void Deposit(decimal amount)
   {
       Balance += amount;
   }
   public void Withdraw(decimal amount)
   {
       if (amount > Balance)
       {
           Console.WriteLine("Insufficient funds.");
           return;
       }
       Balance -= amount;
   }
   public void PrintStatement()
   {
       Console.WriteLine($"{Owner}'s balance: ${Balance}");
   }
}