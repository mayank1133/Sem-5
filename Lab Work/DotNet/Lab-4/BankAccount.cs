/*Create a BankAccount class having constructor accepting initialBalance and 
accountHolderName. Also create Deposite() and withdraw() overloaded 
methods by which user can deposit/withdraw amount using different types 
of parameters (ex. cash, check). 
*/

class BankAccount 
{
    public double initBalance;
    public string accName;
    public BankAccount(double initBalance, string accName)
    {
        this.initBalance = initBalance;
        this.accName = accName;
    }
    public void Deposit(double amount)
    {
        initBalance += amount;
        Console.WriteLine("Deposited: " + amount + ", New Balance: " + initBalance);
    }
    public void Deposit(string checkNumber, double amount)
    {
        initBalance += amount;
        Console.WriteLine("Deposited via check " + checkNumber + ": " + amount + ", New Balance: " + initBalance);
    }
    public void Withdraw(double amount)
    {
        if (amount <= initBalance)
        {
            initBalance -= amount;
            Console.WriteLine("Withdrawn: " + amount + ", New Balance: " + initBalance);
        }
        else
        {
            Console.WriteLine("Insufficient funds for withdrawal of: " + amount);
        }
    }
}