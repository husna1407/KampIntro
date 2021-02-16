using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri customer1 = new GercekMusteri();
            customer1.Name = "Husna";
            customer1.Surname = "IBIS";
            customer1.Id = 1;
            customer1.TcNumber = "22222222222";
            customer1.CustomerNumber = "12344556";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            TuzelMusteri customer2 = new TuzelMusteri();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.SirketName = "kodlama.io";
            customer2.vergiNumber = "73929837498710";

            Customer customer3 = new GercekMusteri();//inheritance kullandığımızdan dolayı hata almadık. 
            Customer customer4 = new TuzelMusteri();//Customer class hem TuzelMusteri hemde GercekMusteri class larının referanslarını tutar.



        }
    }
}
