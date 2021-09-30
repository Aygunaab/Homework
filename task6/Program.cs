using System;


namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?\n");
            Console.WriteLine("*******************************************************************************\n");
            Console.Write("Metni daxil edin: ");
            string Text = Console.ReadLine();
            Console.WriteLine();

            int indexFirst = Text.IndexOf('a');
            int indexLast = Text.LastIndexOf('a');
            if (indexFirst == indexLast)
            {
                Console.WriteLine("a simvolunun sol terefden ve sag terefden indexleri eydir.\n");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz metn serte uygun deyil\n");
            }

            goto start;
        }
    }
}
