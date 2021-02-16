using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention: isimlendirme kuralları
        //syntax
        public void Ekle(Product product) {
            Console.WriteLine(product.Name+ " eklendi");
        }
        public void Ekle2(string Name, int Cost, string Info) {
            Console.WriteLine(Info+" "+Name+"eklendi");
        }
    }
}
