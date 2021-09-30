using System;
using System.Text;
using MyMethodes;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Write("Metin: ");
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder(text);
           

            for (int i = 0; i < text.Length; i++)
            {
               
                if (i % 2 != 0)
                {



                    sb.Append(Char.ToUpper(text[i+1]));
                    
                    
                }
                else
                {
                    sb.Append(text[i]);
                    
                    

                }

                
                
            }

            
            Console.WriteLine(sb.Remove(0,text.Length));

            goto start;
        }
    }
}
