using System;
using System.Collections;
using System.Linq;

namespace task2
{
    class Program
    {


        static void Main(string[] args)
        {
        start:

            Console.WriteLine("Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();
            Console.Write("Metni daxil edin: ");
            string Text = Console.ReadLine();

            int count = 0;
            int counttek = 0;
            for (int i = 0; i < Text.Length; i++)
            {

                if (i % 2 != 0)
                {
                    count++;
                    if (Text[i] == 'a')
                    {
                        counttek++;
                    }
                }

            }
            if (count == counttek)
            {
                Console.WriteLine("Tek yerde dayanan simvollarin hamisi a-dir");
            }
            else
            {
                Console.WriteLine("Tek yerde dayanan {0} simvollardan  {1} denesi a-dir", count, counttek);

            }




            goto start;


        }
    }
}
