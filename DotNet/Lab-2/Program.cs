public class Program
{
    public static void Main(String[] args)
    {
        BankDetails b1 = new BankDetails(); 
        b1.GetDetails(123456, "John Doe", "Bank of Example", 1000.50);  
        b1.DisplayDetails();
    }
        
}