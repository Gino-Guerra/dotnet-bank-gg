public class SavingsAccount : BankAccount {

    public SavingsAccount(string NewOwnersName, double initialBalance)
    : base(NewOwnersName,initialBalance)
    {
        this.Deposit(100);
    }
}

public class CheckingAccount : BankAccount {

    public CheckingAccount(string NewOwnersName, double initialBalance)
    : base(NewOwnersName,initialBalance)
    {
        
    }
}