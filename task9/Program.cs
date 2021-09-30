using System;
using MyMethodes;
namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?");
            Console.WriteLine("******************************************************************************\n");
            Console.WriteLine("Metni daxil edin");
            string text = Console.ReadLine();

            string text1 = text.Substring(0, 3);

            string text2 = text.Substring(3);
            string reverse = (Methodes.ReverseWords(text2)).Trim();
            if (text1 == reverse)
            {
                Console.WriteLine("Beraberdir");
            }
            else
            {
                Console.WriteLine("Beraber deyil");
            }
            goto start;
        }
    }
}
