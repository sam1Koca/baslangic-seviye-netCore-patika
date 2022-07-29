﻿using System;

namespace Donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.WriteLine("Lütfen Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 1; i < sayi; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }


            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını hesaplayalım ve Ekrana Yazdıralım.

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i%2 == 1)
                {
                    tekToplam += i; // i'yi herseferinde tekToplama at ve toplayarak git.
                }

                else
                {
                    ciftToplam += i;
                }
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam); 



            // break, continue

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            for (;;)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

    }
}
