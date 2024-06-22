using Banking_Application;

static void Main(string[] args)
{

    SavingAccount savingAccount = new SavingAccount();
    Console.WriteLine("This is the Savinng account");
    savingAccount.deposit(1000);
    savingAccount.withdraw(500);
    Console.WriteLine();
    savingAccount.resultsOfSavings();


    
    CheckingAccount checkingAccount = new CheckingAccount();
    Console.WriteLine("This is the Savinng account");
    checkingAccount.deposit(2000);
    checkingAccount.withdraw(3000);
    Console.WriteLine();
    checkingAccount.CheckAccount();

}