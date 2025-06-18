class Program
{
    //1).
    //public static void Main(string[] args)
    //{
    //    Addition ad = new Addition();
    //    ad.add(5, 10);
    //    ad.add(5.5f, 10.5f);

    //}

    //2).
    //public static void Main(string[] args)
    //{
    //    Area ar = new Area();
    //    ar.arrea(5);
    //    ar.arrea(5, 10);
    //}

    //3).
    //public static void Main(string[] args)
    //{
    //    Bank.RBI rbi = new Bank.RBI();
    //    rbi.calculateInterest(10000, 2, 0);

    //    Bank.HDFC hdfc = new Bank.HDFC();
    //    hdfc.calculateInterest(10000, 2, 0);

    //    Bank.SBI sbi = new Bank.SBI();
    //    sbi.calculateInterest(10000, 2, 0);

    //}

    //4).
    //public static void Main(string[] args)
    //{
    //    Hospitals.Davakhana hospital = new Hospitals.Davakhana();
    //    hospital.HospitalDetails("Generel Hospital", "north");

    //    Hospitals.Apollo apollo = new Hospitals.Apollo();
    //    apollo.HospitalDetails("Apollo Hospital", "south");

    //    Hospitals.Wockhardt wockhardt = new Hospitals.Wockhardt();
    //    wockhardt.HospitalDetails("Wockhardt Hospital", "East");

    //    Hospitals.Gokul_Superspeciality gokul = new Hospitals.Gokul_Superspeciality();
    //    gokul.HospitalDetails("Gokul Superspeciality Hospital", "West");
    //}

    //5).

    //public static void Main(String[] args)
    //{
    //    Area2 ar = new Area2();
    //    ar.arrea(5);
    //    ar.arrea(5, 10);
    //    ar.arrea(7.5);
    //}

    //6).
    public static void Main(String[] args)
    {
        BankAccount account = new BankAccount(1000, "John Doe");
        account.Deposit(500);
        account.Withdraw(200);
        account.Deposit("Mayank", 300);
        account.Withdraw(1500); 
    }
}
