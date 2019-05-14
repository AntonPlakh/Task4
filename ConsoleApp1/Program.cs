using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, type the word");
            String slovo = Console.ReadLine();
            int l = slovo.Length;

            bool res=true;

            for (int i = 0; i < l/2; i++)
            {
                if (slovo[i] != slovo[l -1- i])
                {
                    res = false;
                    break;
                }
            }
   
             Console.WriteLine(res);
            

        }
    }
}
