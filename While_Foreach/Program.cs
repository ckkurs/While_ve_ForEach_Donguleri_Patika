using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak konsoldan girilen sayıya kadar (sayı daihl ) ortalama hesaplayıp konsola yazdıran program.
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi1=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while(sayac <= sayi1)
            {
               toplam=toplam+sayac;
               sayac++;

            }
            Console.WriteLine("Ortalama:"+ toplam/sayi1);
            //'a' dan zye kadar tüm harfleri konsola yazdır.
            char character='a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }
            Console.Write("***foreach***");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
