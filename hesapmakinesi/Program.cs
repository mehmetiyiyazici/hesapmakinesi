namespace hesapmakinesi;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Kaç Adet Sayı Toplanacak: ");
        // int toplanacakSayiAdedi = int.Parse(Console.ReadLine());
        //
        // int[] sayilar = new int[toplanacakSayiAdedi];
        // int toplam = 0;
        //
        // foreach (int sayi in sayilar)
        // {
        //     Console.Write("Sayı Giriniz: ");
        //     toplam += int.Parse(Console.ReadLine());
        // }
        // Console.Clear();
        // Console.WriteLine("Toplam: " + toplam);


        //-------------------------------------------------------------------------


        Console.WriteLine("\n1.Toplama\n2.Çıkarma\n3.Çarpma\n4.Bölme");
        Console.Write("\nİsleminizi seciniz: ");
        int islem = int.Parse(Console.ReadLine());

        Console.Write("Kaç Adet Sayı İşlem Olacak: ");
        int adet = int.Parse(Console.ReadLine());

        int[] sayilar = new int[adet];
        int sonuc = 0;

        if (islem == 1)
        {
            for (int i = 0; i < adet; i++)
            {
                Console.Write("Sayı Giriniz: ");
                sonuc += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Toplam: " + sonuc);
        }
        else if (islem == 2)
        {
            Console.Write("Sayı Giriniz: ");
            sonuc = int.Parse(Console.ReadLine());
            for (int i = 1; i < adet; i++)
            {
                Console.Write("Sayı Giriniz: ");
                sonuc -= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sonuç: " + sonuc);
        }
        else if (islem == 3)
        {
            Console.WriteLine("Sayı Giriniz: ");
            sonuc = int.Parse(Console.ReadLine());
            for (int i = 1; i < adet; i++)
            {
                Console.WriteLine("Sayı Giriniz: ");
                sonuc *= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sonuç: " + sonuc);
        }
        else if (islem == 4)
        {
            Console.WriteLine("Sayı Giriniz: ");
            sonuc = int.Parse(Console.ReadLine());
            for (int i = 1; i < adet; i++)
            {
                Console.WriteLine("Sayı Giriniz: ");
                sonuc /= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sonuç: " + sonuc);
        }

        //-------------------------------------------------------------------------
        //     Console.WriteLine("Sayı Giriniz: ");
        //     int inputSayi = int.Parse(Console.ReadLine());
        //     bool islemMi = true;
        //
        //
        //     while (islemMi)
        //     {
        //         Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        //         Console.WriteLine("1 Toplama");
        //         Console.WriteLine("2 Çıkarma");
        //         Console.WriteLine("3 Bölme");
        //         Console.WriteLine("4 Çarpma");
        //         Console.WriteLine("e. Çıkış");
        //         
        //         string inputSecim = Console.ReadLine();
        //         if (inputSecim == "e" || inputSecim == "E")
        //         {
        //             islemMi = false; 
        //             continue; 
        //         }
        //         
        //
        //         if (inputSecim == "1")
        //         {
        //             Console.WriteLine("Sayı giriniz: ");
        //             int inputToplama = int.Parse(Console.ReadLine());
        //             inputSayi += inputToplama;
        //             Console.WriteLine("Toplama sonucu: " + inputSayi);
        //             
        //         }
        //         else if (inputSecim == "2")
        //         {
        //             Console.WriteLine("Sayı giriniz: ");
        //             int inputCıkarma = int.Parse(Console.ReadLine());
        //             inputSayi -= inputCıkarma;
        //             Console.WriteLine("Çıkarma sonucu: " + inputSayi);
        //             
        //         }
        //         else if (inputSecim == "3")
        //         {
        //             Console.WriteLine("Sayı giriniz: ");
        //             int inputBolme = int.Parse(Console.ReadLine());
        //             inputSayi /= inputBolme;
        //             Console.WriteLine("Bölme sonucu: " + inputSayi);
        //             
        //         }
        //         else if (inputSecim == "4")
        //         {
        //             Console.WriteLine("Sayı giriniz: ");
        //             int inputCarp = int.Parse(Console.ReadLine());
        //             inputSayi *= inputCarp;
        //             Console.WriteLine("Çarpma sonucu: " + inputSayi);
        //             
        //         }
        //         
        //         
        //     }
        //     
        //
        //
        //
        //     
        // }
        //
    }
}