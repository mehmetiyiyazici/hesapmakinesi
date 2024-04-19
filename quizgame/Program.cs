namespace quizgame;

class Program
{
    static void Main(string[] args)
    {
        string[] sorular = ["Gökyüzü Ne Renktir? ","Türkiye'nin Başkenti Neresidir?"];
        string[] cevaplar = ["Mavi","Ankara"];
        string[] secenekler = ["Kırmızı|Mavi|Pembe|Mor" ,"İstanbul|Ankara|İzmir"];

        int dogrucevap = 0;
        int yanliscevap = 0;

        for (int i = 0; i < sorular.Length; i++)
        {
            Console.WriteLine($"Soru {i + 1}: {sorular[i]}");
            string[] secenekler2 = secenekler[i].Split('|');
            for (int j = 0; j < secenekler2.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {secenekler2[j]}");
            }

            Console.WriteLine("Cevabınız Nedir: ");
            string inputcevap = Console.ReadLine();

            if (inputcevap == cevaplar[i])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Doğru");
                Console.ResetColor();
                dogrucevap++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış Cevap Verdiniz");
                Console.ResetColor();
                yanliscevap++;
            }
            if (i < sorular.Length - 1)
            {
                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadLine();
                
            }

        }
        Console.WriteLine($"Toplam doğru cevap sayısı: {dogrucevap} / {sorular.Length}");
    }
}  
        
    