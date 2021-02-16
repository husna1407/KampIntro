using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //urun1
            product1.Name = "Elma";//urun1.adi
            product1.Cost = 15;//urun1.fiyati
            product1.Info = "Amasya Elması";//urun1.aciklama

            Product product2 = new Product(); //urun2
            product2.Name = "Karpuz";//urun2.adi
            product2.Cost = 80;//urun2.fiyati
            product2.Info = "Diyarbakır Karpuzu";//urun2.aciklama

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products) {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Cost);
                Console.WriteLine(product.Info);
                Console.WriteLine("----------------------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);//verimli kod
            sepetManager.Ekle2("elma ", 45, "yeşil");//verimsiz kod



        }
    }
}
