using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Odev1
{
    class soru3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n+" "+"adet kelime girin\n");
            string[] kelimeler = new string[n];
            for(int i = 0; i < n; i++)
            {
                kelimeler[i] = Console.ReadLine();
            }
            
            for(int j=n-1; j>=0; j--)
            {
                Console.WriteLine(kelimeler[j]+" ");
            }
            Console.ReadKey();

        }
    }
}
