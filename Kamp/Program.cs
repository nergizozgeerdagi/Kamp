using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Ders Bilgilerine Erişmek İçin Tıklayınız.";
            string iyiDilek = "İyi ve sağlıklı günler dileriz.";
            string guzDonemi = "Güz Dönemi Not Ortalamasına Göre: ";
            int ogrenciSayisi = 16000;
            double sinifOrtguz = 2.57;
            bool sistemeGirisYapmisMi = false;
            double ortGuz = 3.50;
            double ortBahar = 3.46;

            if (ortGuz > ortBahar)
            {
                Console.WriteLine("Ortalaman düştü");
            }
            else if (ortGuz < ortBahar)
            {
                Console.WriteLine("Ortalaman arttı");
            }
            else
            {
                Console.WriteLine("Ortalaman değişmedi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Hatalı giriş, şifre veya kullanıcı adı yanlış girildi. Tekrar giriş yap butonu");
            }
            Console.WriteLine("Güz Dönemi Not Ortalamanız: " + ortGuz);
            Console.WriteLine("Bahar Dönemi Not Ortalamanız: " + ortBahar);
            if (sinifOrtguz < ortGuz)
            {
                Console.WriteLine(guzDonemi + "Sınıf ortalamasının üstündesiniz.");
            }
            else if (sinifOrtguz > ortGuz)
            {
                Console.WriteLine(guzDonemi + "Sınıf ortalamasının aşağısındasınız.");
            }
            else
            {
                Console.WriteLine(guzDonemi + "Sınıf ortalamasıyla eşit ortalamaya sahipsiniz.");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine("Güncel Öğrenci Sayısı: " + ogrenciSayisi);
            Console.WriteLine(iyiDilek);


        }
    }
}