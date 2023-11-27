public class BankAccount {

private double Balance = 0;

public string OwnersName = "";

public BankAccount(string NewOwnersName, double initialBalance) {

    this.OwnersName = NewOwnersName;
   this.Deposit(initialBalance);
//    this.Deposit(100);
}

public double Deposit(double amount){
    if(amount < 0.00){
        throw new Exception("Nope");
    }
    this.Balance += amount;
    return this.Balance;
}
public double Withdraw(double amount){
    if(amount < 0.00 ){
        throw new Exception("No negative numbers");
    }
    if(amount > this.Balance){
        throw new Exception("you broke bro withdraw less");
    }

    this.Balance -= amount;
    return this.Balance;
}
public double Getbalance(){
return this.Balance;
}
}

