using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)//--->Bunu yaparsak konut taşıt ihtiyaç hangisini seçersek seçelim hesaplar
        {
            //Başvuran bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); böyle yaparsak tüm başvuruları konut kredisine  bağımlı hale getiririz Yanlış
            krediManager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
