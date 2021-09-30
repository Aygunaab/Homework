using System;
using System.Linq;

namespace task1

{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece dene coxdur?");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();
            Console.Write("Metni daxil edin: ");
            string Text = Console.ReadLine();
            Console.WriteLine();
            Text = Text.ToLower();
            String Charsa = "a";
            String Charsb = "b";
            int counta = 0;
            int countb = 0;
            int TextLengts = Text.Length;
            int CharsaLengts = Charsa.Length;
            int CharsbLengts = Charsb.Length;

            for (int i = 0; i <= (TextLengts - CharsaLengts); i++)
            {
                if (Text.Substring(i, CharsaLengts) == Charsa)
                {
                    counta++;
                }
            }
            Console.WriteLine("Verilmis metnde a herfleri {0}  denedir \n", counta);

            for (int j = 0; j <= (TextLengts - CharsbLengts); j++)
            {
                if (Text.Substring(j, CharsbLengts) == Charsb)
                {
                    countb++;

                }
            }
            Console.WriteLine("Verilmis metnde b herfleri {0}  denedir\n ", countb);


            double Result = counta - countb;
            if (counta == countb)
            {
                Console.WriteLine("Verilmis metnde a herfinin sayi  b herfinin sayina  beraberdir\n");
            }
            else
            {
                Console.WriteLine("a  simvolun sayi b simvolun sayindan {0} dene coxdur\n", Result);
            }
            goto start;
        }
    }
}

