using System;
using System.Linq;
using System.Text;

namespace task_11
{
    class Program
    {
        
        static void Main(string[] args)
        {
       
            Console.WriteLine("Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu \n ve eyni zamandan butun { b}simvollarinin qabagina { a}simvolunu yaz.");
            Console.WriteLine("*********************************************************\n");
            string word = Console.ReadLine();
            var builder = new StringBuilder();
           
            foreach (var c in word)
            {
                builder.Append(c);
                if (c =='a')
                {
                    builder.Append('b');
                }

                else if (c == 'b')
                {
                    builder.Append('a');
                }
            }
           
            Console.WriteLine("Evvelki soz: {0}", word);
            word = builder.ToString();
            Console.WriteLine("Sonraki soz: {0}", word);

        }



    }
    }

