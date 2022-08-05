using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBüyükDiziSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("sayi giriniz:");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            foreach (var i in sayilar)
            {
                Console.WriteLine("{0}",i);
            }

            Console.WriteLine("{0} en büyük toplam", sayilar[8] + sayilar[9]);
            Console.ReadLine();
        }
    }
}
