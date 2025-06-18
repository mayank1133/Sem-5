/*3.Create a class named RBI with calculateInterest() method. Create another    
classes HDFC, SBI, ICICI which overrides calculateInterest() method. */

class Bank { 
    public class RBI
    {
        public virtual void calculateInterest(double amt, double time, double interest)
        {
            interest = 5; 
            Console.WriteLine("Calculating interest in RBI: " + (amt * time * interest / 100));
        }
    }
    public class HDFC : RBI
    {
        public override void calculateInterest(double amt, double time, double interest)
        {
            interest = 6.5; 
            Console.WriteLine("Calculating interest in HDFC: " + (amt * time * interest / 100));
        }
    }
    public class SBI : RBI
    {
        public virtual void calculateInterest(double amt, double time, double interest)
        {
            interest = 6; 
            Console.WriteLine("Calculating interest in SBI: " + (amt * time * interest / 100));
        }
    }
}