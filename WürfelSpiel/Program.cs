using System.Linq.Expressions;

namespace Würfel_kein_Spiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lower = 1;
            int upper = 9;
            int lowerP = 10;
            int upperP = 25;    
            int ZahlP = random.Next(lowerP, upperP);
            int Zahl1 = random.Next(lower, upper);
            int Zahl2 = random.Next(lower, upper);
            int Zahl3 = random.Next(lower, upper);
            int sum = Zahl1 + Zahl2 + Zahl3;
            int sum2 = Zahl1 + Zahl2;


            Console.WriteLine("Das Spiel funktioniert indem du so nahe wie möglich an die Zahl 20 kommst, du würfelst mit Würfeln zwischen " + lower + " und " + upper);
            Console.WriteLine("Das Programm gibt dann eine Zahl aus, du musst näher an 20 sein, sonst hat das Programm gewonnen. Das Spiel ist ähnlich wie Blackjack");
            Console.WriteLine("Möchtest du deinen ersten Würfel werfen? [y|n]");

            string input = Console.ReadLine();
            if (input.ToLower() == "y")

                Console.WriteLine("Du Würfelst und würflest eine " + Zahl1);

            else
                Environment.Exit(0);

            Console.WriteLine("Möchtest du noch einen Würfel würfeln? [y|n]");
            string input2 = Console.ReadLine();
            if (input2.ToLower() == "y")

               Console.WriteLine("Du hast noch einmal gewürfelt und hast eine " + Zahl2 + " gewürfelt!");
            else 
                Environment.Exit(0);

            Console.WriteLine("Du hast jetzt eine Summe von " + sum2 + ". Möchtest du noch einmal würfeln? ABER denk dran, wenn du über 20 bsit hast du verloren, du musst nur höher als der Geber sein. [y|n]");

            string input3 = Console.ReadLine();
            if (input3.ToLower() == "y")

               Console.WriteLine("Du würfelst noch einmal und würfelst eine " + Zahl3);

            else 
                Environment.Exit(0);

            Console.WriteLine("Somit hast du eine Summe von " + sum);         
        }
    }
}
