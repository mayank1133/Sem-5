/*4. Create a class Hospital with HospitalDetails() method. Create another     
classes Apollo, Wockhardt, Gokul_Superspeciality which overrides     
HospitalDetails() method. */

class Hospitals
{
    public class Davakhana
    {
        public virtual void HospitalDetails(string Name, string address)
        {
            Name = "Generel Hospital";
            Console.WriteLine("  Name: " + Name);
            Console.WriteLine("  Address: " + address);
        }
    }

    public class Apollo : Davakhana
    {
        public override void HospitalDetails(string Name, string address)
        {Name = "Apollo Hospital";
            Console.WriteLine("  Name: " + Name);
            Console.WriteLine("  Address: " + address);
        }
    }   

    public  class Wockhardt : Davakhana
    {
        public override void HospitalDetails(string Name, string address)
        {
            Name = "Wockhardt Hospital";
            Console.WriteLine("  Name: " + Name);
            Console.WriteLine("  Address: " + address);
        }
    }   
    public class Gokul_Superspeciality : Davakhana
    {
        public override void HospitalDetails(string Name, string address)
        {
            Name = "Gokul Superspeciality Hospital";
            Console.WriteLine("  Name: " + Name);
            Console.WriteLine("  Address: " + address);
        }
    }
}