using System;

namespace Odevler
{
    class Soruiki
    {
        static void Main(string[] args)
        {
            
            //Ödev 1
            //Soru 2
            //Kullanıcıdan 2 adet sayı al 'n,m' sonra n adet pozitif sayı girilmesini iste 
            //girilen sayılardan 'm'e eşit veya tam bölününenleri console yazdır.

            System.Console.WriteLine("Lütfen 'N' Sayısını Giriniz");
            int nSayisi = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Lütfen 'M' Sayısını Giriniz");
            int mSayisi = int.Parse(Console.ReadLine());
            int[] dizi2 = new int[nSayisi];
            for (int i = 0; i < dizi2.Length; i++)
            {
                System.Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",i+1);
                dizi2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dizi2.Length; i++)
            {
                if(dizi2[i]%mSayisi == 0)
                    System.Console.WriteLine(dizi2[i]+" 'M'Sayısına Tam Bölünmektedir.");
                else if (dizi2[i]==mSayisi)
                {
                    System.Console.WriteLine(dizi2[i]+" 'M' Sayısına Eşittir.");
                }
                else
                {
                    System.Console.WriteLine(dizi2[i]+" 'M' Sayısına Tam Bölünmemektedir ve Eşit Değildir.");
                }
            }



           





        }
    }
}
