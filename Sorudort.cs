using System;

namespace Odevler
{
    class Sorudort
    {
        static void Main(string[] args)
        {
            
            //Ödev 1
            //Soru 4
            //Kullanıcan Bir Cümle Al
            //Sonra Cümledeki Toplam kelime ve harf sayısını yazdır.
            int harfsayisi = 0;
            System.Console.WriteLine("Lütfen Bir Cümle Giriniz");
            string cumle = Console.ReadLine();
            string[] kelime = cumle.Split(" ");
            System.Console.WriteLine("Verilen Cümlede {0} Kelime Vardır.",kelime.Length);
            for (int i = 0; i < kelime.Length; i++)
            {
                 char[] harfdizi = kelime[i].ToCharArray();
                harfsayisi += harfdizi.Length;
            }
            System.Console.WriteLine("Verilen Cümlede {0} Harf Vardır.",harfsayisi);



           





        }
    }
}
