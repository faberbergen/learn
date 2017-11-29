using System;

namespace af
{
    class Program
    {
        static void Main(string[] args)
        {
            // erste Zahl eingeben und anzeigen
            Console.WriteLine("Bitte geben sie eine Zahl ein!");
            string s = Console.ReadLine();
            Console.WriteLine("Die erste Zahl ist " + s);

            // Rechenoperator abfragen
            Console.WriteLine("Bitte geben sie die gewünschte Rechenart ein: ( + - * :) ");
            string Rechenzeichen = Console.ReadLine();
            Console.WriteLine("Das Rechenzeichen ist : "+ Rechenzeichen);

            // zweite Zahl eingeben und anzeigen
            Console.WriteLine("Bitte geben sie eine weitere  Zahl ein!");
            string b = Console.ReadLine();
            Console.WriteLine("Die zweite Zahl ist " + b);

            int si = Convert.ToInt32(s);
            int bi = Convert.ToInt32(b);
            int Ergebnis = 0;
            if (Rechenzeichen == "+")
            {
              Ergebnis = si + bi;
            }
            if (Rechenzeichen == "-")
            {
                Ergebnis = si - bi;
            }
            if (Rechenzeichen == "*")
            {
                Ergebnis = si * bi;
            }
            if (Rechenzeichen == ":")
            {
                Ergebnis = si / bi;
            }


            string sErgebnis = Ergebnis.ToString();
            
            Console.WriteLine("Das Ergebnis ist: " + sErgebnis );
            


        }
    }
}
