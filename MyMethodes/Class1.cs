using System;

namespace MyMethodes
{
    public class Methodes
    {


        public static void ConsRead()
        {
            Console.WriteLine("**************************************************************************************\n");
            Console.WriteLine("Metni daxil edin\n");

        }

        public static string ReverseWords(string str)
        {
            string result = " ";
            string[] res = str.Split(' ');
            foreach (var item in res)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    result += item[i];
                }
                if (item != res[res.Length - 1])
                    result += " ";
            }
            return result;
        }
        public static int GetCount(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }
            return count;
        }
        public static char[] GetChararr(string text)
        {
            int counter = GetCount(text);
            char[] arr = new char[counter];
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                arr[index] = text[i];

                index++;
            }
            return arr;

        }
    }
}
