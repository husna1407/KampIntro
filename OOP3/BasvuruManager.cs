using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection -- dependency injection
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)//bu interface bütün class ların referansını tuttuğu için hangi krediye göre yapacağını bilir. 
        {
            //başvuran bilgilerini değerlendirme
            //
            creditManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler) {
                kredi.Hesapla();
            }
        }
    }
}
