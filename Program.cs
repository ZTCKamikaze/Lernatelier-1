namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lower = 1;
            int upper = 100;
            Random zufall = new Random();
            int nummer = zufall.Next(1, 100);
            bool raten = true;

            Console.WriteLine("Ich werde mir eine Zahl zwischen " + lower + " und " + upper + " audenken.");
            Console.WriteLine("Und Sie werden sie veruschen zu eraten.In so wenigen versuchen wie möglich");
            Console.WriteLine("Wählen Sie eine Zahl zwischen " + lower + " und " + upper);
            


           while (raten == true)
           {
              int zahl1 = Convert.ToInt32(Console.ReadLine());
                if (zahl1 < nummer)
                {
                    Console.WriteLine("Versuchen sie es höher");
                }
                
                if (zahl1 > nummer)
                {
                    Console.WriteLine("Veruschen Sie es tiefer");
                }
                
                if (zahl1 == nummer)
                {
                    Console.WriteLine("Super, Sie haben meine Zahl gefunden!");
                    raten = false;
                }
           }
        }
    }
}