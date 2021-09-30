using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?\n");
            Console.WriteLine("****************************************************************************************\n");
            Console.Write("Yoxlamaq istediyiniz metni daxil edin:");
            string CharA = "a";
            string Text = Console.ReadLine();
            int n = Text.IndexOf(CharA, 0);
            if (n % 2 == 0)
            {
                Console.WriteLine("a simvolunun yeri cut ededdir");
            }
            else
            {
                Console.WriteLine("a simvolunun yeri tek ededdir");
            }
            goto start;
        }
    }
}
