using System;
using System.Collections.Generic;

namespace Patika_DevAlgoritma3
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int kareler = 0;
            int toplam1 = 0;
            
            Console.Write("Kaç tane sayı gireceğinizi yazınız: ");
            int limit = int.Parse(Console.ReadLine());
            List<int> kucukdizi = new List<int>();//küçük olan sayıların farklarının toplamı için dizi oluşturuldu.
            List<int> buyukdizi = new List<int>();//büyük olan sayıların farklarının toplamı için dizi oluşturuldu.
            for (int i = 0; i < limit; i++)
            {
                Console.Write((i+1) + ". Sayıyı giriniz: ");
                int sayi1 = int.Parse(Console.ReadLine());
                if (sayi1 < 67)
                {
                    kucukdizi.Add(67 - sayi1);//67den küçük olan sayılar 67den çıkarılacak bu diziye eklenicek
                }
                else
                {
                    buyukdizi.Add(sayi1 - 67);//67den büyük olan sayılar 67den çıkarılıp bu diziye eklenecek
                    
                }

            }
            foreach (var item in kucukdizi)
            {
                toplam += item ;//dizi içerisinde dönecek sayıların hepsini toplayacak.
                
            }
            Console.WriteLine("67den küçük olan sayıların farklarının toplamı: {0}",toplam);
            foreach (var item in buyukdizi)
            {
               
                kareler = item * item;//dizi içerisinde dönecek kareleri alınacak
                toplam1 += kareler;// alınan karelerin hepsini toplayacak
                
            }
            Console.WriteLine("67den büyük olan sayıların farklarının mutlak karelerinin toplamı: {0}",toplam1);
        }
    }
}
