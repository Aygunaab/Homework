using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace task_10
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Verilmish metinde butun reqemleri legv et.");
            Console.WriteLine("******************************************/n");
            Console.Write("Metni daxil edin");
            string input = Console.ReadLine();
            string chars = new String(input.Where(c => c != '-' && (c < '0' || c > '9')).ToArray());
            Console.WriteLine(chars);
        }
    }
}
