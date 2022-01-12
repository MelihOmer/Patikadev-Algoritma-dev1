using System;

namespace Odevler
{
    class Sorubir
    {
        static void Main(string[] args)
        {
            
            //Ödev 1
            //Soru 1
            //Kullanıcıdan bir sayı al'n' sonra 'n' adet sayı girilmesini iste ve bu sayılardan çift olanları yazdır.
            System.Console.WriteLine("Lütfen Bir Pozitif Sayı Giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] dizi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                System.Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if(dizi[i]%2 == 0)
                    System.Console.WriteLine("Çift Olan Sayı: "+dizi[i]);
                else
                    System.Console.WriteLine(dizi[i]+" Sayısı Çift Değildir.");
            }



           





        }
    }
}
