using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?\n");
            Console.WriteLine("*****************************************************************************************\n");
            Console.Write("Metni daxil edin:");
            string Text = Console.ReadLine();
            Console.WriteLine();
            int indexA = Text.IndexOf('a');
            int indexB = Text.IndexOf('b');
            int indexC = Text.IndexOf('c');
            if (indexA < indexB && indexB < indexC)
            {
                Console.WriteLine("a simvolu b simvolundan qabaq ve oda c simvolundan qabaq gelir\n");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz metn serte uygun gelmir\n");
            }
            goto start;
        }
    }
}
