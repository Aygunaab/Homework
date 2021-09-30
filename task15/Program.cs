using System;
using System.Linq;
using System.Text;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verilmish metinde ilk ve son simvol eynidirse, \n ve metn daxilinde yanashi gelen { a} simvolu varsa,\nve metn daxilinde { b}simvolu yoxdursa o zaman bu metnde\n butun { c} simvollari yox et  neticede alinan metn zerkalni olub olmadigini yoxla.");
            Console.WriteLine();
            
            
            string word = Console.ReadLine();
            char a = 'a';
            char b = 'b';
            char c = 'c';

            StringBuilder sb = new StringBuilder();

            bool isTrue = false;

            if (word[0] == word[word.Length - 1])
            {
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (word[i] == word[i + 1] && !word.Contains(b))
                    {
                        isTrue = true;
                    }
                }
            }

            if (isTrue)
            {
                foreach (var item in word)
                {
                    if (item != c)
                    {
                        sb.Append(item);
                    }
                }
            }

            string start = "";
            string end = "";
            for (int i = 0; i <word.Length; i++)
            {
                 start = sb.ToString().Substring(0,i/2);
                end = sb.ToString().Substring(i / 2);
            }

            string reverseEnd = "";

            foreach (var item in end.Reverse())
            {
                reverseEnd += item;
            }


            if (start == reverseEnd)
            {
                Console.WriteLine("Zerkalniyh");
            }


        }
    }
}
