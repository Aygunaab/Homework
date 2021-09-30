using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan  hansi birinci gelir?\n");
            Console.WriteLine("**************************************************************************************\n");
            Console.Write("Metni daxil edin: ");
            string Text = Console.ReadLine();
            Console.WriteLine();

            char[] Chars = { 'a', 'b', 'c' };

            int indexA = Text.IndexOf(Chars[0], 0);
            int IndexB = Text.IndexOf(Chars[1], 0);
            int IndexC = Text.IndexOf(Chars[2], 0);
            if (indexA != -1 && IndexB != -1 && IndexC != -1)
            {
                if (indexA < IndexB && indexA < IndexC)
                {
                    Console.WriteLine("En birinci a simvolu gelir");
                }
                else if (IndexB < indexA && IndexB < IndexC)
                {
                    Console.WriteLine("En birinci b simvolu gelir");
                }
                else if (IndexC < IndexB && IndexC < indexA)
                {
                    Console.WriteLine("En birinci c simvolu gelir");
                }

            }
            else
            {
                Console.WriteLine("Daxil olan metn tapsirigin sertine uygun deyil. Duzgun metn elave edin\n");
            }
            goto start;

        }
    }
}
