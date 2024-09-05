using System;

namespace bedenKitleEndeksi {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Beden Kitle Endeksi hesaplayıcısına hoş geldiniz!\n");
            
            Console.WriteLine("Kilonuzu Giriniz : \n");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu 'cm' cinsinde girniz : \n");
            double boy = Convert.ToDouble(Console.ReadLine());
            boy /= 100;

            double bki = kilo / (boy*boy);
            Console.WriteLine ($"Beden Kitle Endeksini  : {bki}\n");

            if (bki < 18.5)
            {
                Console.WriteLine("Zayıfsınız.");

            }
            else if (bki > 18.5 && bki < 24.9)
            {
                Console.WriteLine ("Normal");
            }
            else if (bki > 25 && bki < 29.9)
            {
                Console.WriteLine("Fazla Kilolu");
            }
            else if (bki > 30 )
            {
                Console.WriteLine("Obezite");
                if (bki > 30 && bki < 34.9)
                {
                    Console.WriteLine("1. Derece Obezite");
                    Console.WriteLine("Sağlıklı bir yaşam için düzenli egzersiz yapın!");
                }
                else if (bki > 35 && bki < 39.9)
                {
                    Console.WriteLine("2. Derece Obezite");
                    Console.WriteLine("Sağlığınız için doktorunuza veya bir diyetisyene danışın!");
                }
                else if (bki > 40)
                {
                    Console.WriteLine("3. Derece Obezite");
                    Console.WriteLine("Sağlığınız için acilen doktorunuza veya diyetisyene danışın!");
                }
            }

        }
    }
}