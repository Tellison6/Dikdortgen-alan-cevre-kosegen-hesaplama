using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdortgen_alan_hesaplayıcı
{
    public class Program
    {
        static void Main(string[] args)
        {
            int kısa, uzun, alan,cevre;
            double kosegen;

            Console.WriteLine("Kısa kenarı giriniz: ");
            kısa = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzun kenarı giriniz: ");
            uzun= int.Parse(Console.ReadLine());
            alan = kısa * uzun;
            cevre = (kısa + uzun) * 2;
            kosegen = Math.Sqrt(uzun*uzun + kısa*kısa);
            Console.WriteLine("Alan: {0}",alan);
            Console.WriteLine("Cevre: {0}",cevre);
            Console.WriteLine("Kosegen: {0}",kosegen);
            
            Console.ReadLine();
        }
    }
}
