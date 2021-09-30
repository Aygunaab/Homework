using System;


namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et.");
            Console.WriteLine("******************************************************************************************\n");
            Console.WriteLine("Metni daxil edin\n");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char LoverSimvol = text[i];
                    Console.WriteLine(Char.ToLower(LoverSimvol));


                }
                else if (i % 2 != 0)
                {

                    char UpperSimvol = text[i];
                    Console.WriteLine(Char.ToUpper(UpperSimvol));


                }


            }
            goto start;
        }
    }
}
