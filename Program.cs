// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int age = 21;
// age = "twentyone"
string name = "kyle";
// Console.WriteLine($"your name is {name} and you're {age} years old ");

try{

SavingsAccount newAccount = new SavingsAccount("steve",100.99);

 newAccount.Withdraw(40);
 newAccount.Deposit(50);

Console.WriteLine($"{newAccount.OwnersName} balance is {newAccount.Getbalance()}");

}catch (Exception err){
    Console.WriteLine($"you got an error: {err.Message}");
}