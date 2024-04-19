namespace paraustu;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Adınızı Giriniz: ");
        string ad = Console.ReadLine();

        Console.WriteLine("Soyadınızı Giriniz ");
        string soyad = Console.ReadLine();
        string tamAd = ad + " " + soyad;
        Console.WriteLine("Hoşgeldiniz " + tamAd);
        
        Console.Write("Sipariş Tutarınızı Giriniz: ");
        int tutar = int.Parse(Console.ReadLine());

        Console.WriteLine("Kredi Kartı veya Nakiti Seçiniz: ");
        string odeme = Console.ReadLine();
        
        Console.WriteLine("Ödemek İstediğiniz Tutarı Giriniz: ");
        int odeme2 = int.Parse(Console.ReadLine());

        if (tutar == odeme2)
        {
            Console.WriteLine("Ödeme Başarılı");
           
        }
        else if (tutar > odeme2)
        {
            Console.WriteLine("Eksik Ödeme Yaptınız");
            
        }
        else
        {
            Console.WriteLine("Para Üstü: " + (tutar - odeme2));
        }

    }
}