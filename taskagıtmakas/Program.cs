namespace taskagitmakas;

class Program
{
    static void Main(string[] args)
    {
        string[] secenekler = ["Taş", "Kağıt", "Makas"];

        int kullanici = 0;
        int bot = 0;


        while (true)
        {
            Console.WriteLine("Taş,Kağıt,Makas Birini Seçiniz ");
            string inputKullanici = Console.ReadLine();
            Random pc = new Random();
            int bilgisayar = pc.Next(3);
            
            if (inputKullanici == "Taş" && secenekler[bilgisayar] == "Kağıt")
            {
                bot++;
            }
            if (inputKullanici == "Taş" && secenekler[bilgisayar] == "Makas")
            {
                kullanici++;
            }
            if (inputKullanici == "Makas" && secenekler[bilgisayar] == "Kağıt")
            {
                kullanici++;
            }
            if (inputKullanici == "Makas" && secenekler[bilgisayar] == "Taş")
            {
                bot++;
            }
            if (inputKullanici == "Kağıt" && secenekler[bilgisayar] == "Taş")
            {
                kullanici++;
            }
            if (inputKullanici == "Kağıt" && secenekler[bilgisayar] == "Makas")
            {
                bot++;
            }
            if (inputKullanici == "Çıkış")
            {
                break;
            }

            Console.WriteLine("Kullanıcı " + kullanici );
            Console.WriteLine("Bot " + bot );
            
            
        }
        
        
    }
}