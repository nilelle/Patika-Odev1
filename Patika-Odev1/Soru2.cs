using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Odev1
{
    internal class Soru2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İki tane pozitif tam sayı girin:\n");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n+" "+"tane pozitif tam sayı girin:");
            int sayi;
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                
                sayilar[i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine(m+"'ye eşit ve tam bölünen sayılar:");
            
            foreach (var item in sayilar)
            {
                if(item==m || item%m == 0)
                {
                    Console.WriteLine(item+" ");
                }

            }
            Console.ReadKey();  



        }

    }
}

