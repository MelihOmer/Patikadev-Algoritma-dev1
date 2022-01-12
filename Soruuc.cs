using System;

namespace Odevler
{
    class Soruuc
    {
        static void Main(string[] args)
        {
            
            //Ödev 1
            //Soru 3
            //Kullanıcıdan Bir Sayı al 'n'
            //Sonra 'n' adet kelime girmesini iste
            //girilen kelimeleri sondan başa dogru yazdır.
            System.Console.WriteLine("Lütfen Bir 'N' Sayısı Giriniz.");
            int nSayisi = int.Parse(Console.ReadLine());
            string[] dizi = new string[nSayisi];
            for (int i = 0; i < dizi.Length; i++)
            {
                System.Console.WriteLine("Lütfen {0}. Kelimeyi Giriniz.",i+1);
                dizi[i] = Console.ReadLine();
            }
            System.Console.WriteLine("******Kelimeleri Ayrı Ayrı Kendi İçlerinde Tersten Yazılışı******");
            for (int i = 0; i < dizi.Length; i++)
            {
                char[] metindizi = dizi[i].ToCharArray();
                Array.Reverse(metindizi);
                string returnmetin = new string(metindizi);
                System.Console.WriteLine(returnmetin);
            }
            System.Console.WriteLine("******Verilen Listenin Tersten Sıralanışı******");
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                System.Console.WriteLine(item);
            }



           





        }
    }
}
