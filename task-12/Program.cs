using System;
using System.Linq;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et.");
            Console.WriteLine("*************************************************************************************************\n");

            string str = Console.ReadLine();
            int firstIndexA = str.IndexOf('a');
            int lastIndexA = str.LastIndexOf('a');
            //string chars = "";
            int count = 0;
            string first=str.Substring(0,firstIndexA+1);
            string last=str.Substring(lastIndexA);
            for (int i = 0; i < str.Length-first.Length-last.Length; i++)
            {
                count++;
            }
            string midium=str.Substring(firstIndexA+1,count);

            for (int i = 0; i < midium.Length; i++)
            {
                
               midium = string.Join("", midium.Split('a'));
                
            }
            Console.WriteLine(midium);

            Console.WriteLine(string.Concat(first,midium,last));





        }
    }
}
