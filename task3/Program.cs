using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine(" Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.\n");
            Console.WriteLine("****************************************************************************************\n");
            Console.Write("Yoxlamaq istediyiniz metni daxil edin:");

            string Text = Console.ReadLine();



            int countsingleb = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (i % 2 != 0 && Text[i] == 'b')
                {
                    countsingleb++;

                }




            }

            Console.WriteLine("tek yerde dayanan simvollardan necesi b -ye beraberdir.Cavab: {0}", countsingleb);





            goto start;
        }
    }
}
