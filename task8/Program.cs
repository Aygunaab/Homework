using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et.");
            Console.WriteLine("************************************************************************************************\n");
            Console.Write("Metni daxil edin: ");
            string Text = Console.ReadLine();
            Console.WriteLine();
            int indexFirstA = Text.IndexOf('a');
            int NewIndex = indexFirstA + 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Text[NewIndex]);
            }
            goto start;
        }
    }
}
