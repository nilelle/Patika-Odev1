using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Odev1
{
    public class Soru4
    {
        static void Main(string[] args)
        {
            string cumle;
            Console.Write("Cümle Girin  : ");
            cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            Console.ReadKey();


        }

    }
    
}
