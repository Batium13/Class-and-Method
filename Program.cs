using System;

namespace Class_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
           //Söz dizimi
           //class SinifAdi
           //{
                /* [Erişim belirleyici] [Veri Tipi] ÖzellikAdi;
                   [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdı[Parametre Lsitesi]
                    {
                        Metot Komutları;
                    }
                 */
           //}

           /* Erişim belirleyicileri 
            *Private ==> tANIMLANDIĞI SINIF İÇERİSİNDE ERİŞİM
            *Public  ==> HERYERDEN ERİŞİM SAĞLANABİLİR
            *Internal ==> KENDİ BULUNDUĞU PROJE İÇERİSİNDE ERİŞİLEBİLEN DEĞİŞKENLER VE METOTLARA
            *Protected ==> SADECE TANIMLANDIĞI SINIF VE VEYA KALITIM ALDIĞI SIBNIFLARDA ERİŞİLEBİLİR
           */

            Calisan calisan1 = new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=12543678;
            calisan1.Departman="İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            Console.WriteLine("*****************************");

            Calisan calisan2 = new Calisan();

            calisan2.Ad="Batu";
            calisan2.Soyad="Matu";
            calisan2.No=99999999;
            calisan2.Departman="Bakım Bölümü";

            calisan2.CalisanBilgileri();


        }
    }

    class Calisan{

        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri(){

            Console.WriteLine("Çalışan Adı : {0}",Ad);
            Console.WriteLine("Çalışan Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışanın numarası : {0}",No);
            Console.WriteLine("Çalışanın departmanı : {0}",Departman);

        }
    }
}
