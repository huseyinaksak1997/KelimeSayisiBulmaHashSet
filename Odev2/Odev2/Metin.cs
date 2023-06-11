using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class Metin
    {
        public Metin()
        {
            Liste<string> liste = new Liste<string>();
            Console.WriteLine("1.metini giriniz:");
            liste.Add(Console.ReadLine().ToLower());

            Console.WriteLine("2.metini giriniz:");
            liste.Add(Console.ReadLine().ToLower());

            Console.WriteLine("3.metini giriniz:");
            liste.Add(Console.ReadLine().ToLower());
            liste.HashEkle(liste[0]);
            liste.HashEkle(liste[1]);
            liste.HashEkle(liste[2]);
            Console.WriteLine("Toplam girilen kelime sayısı:"+liste.kelimeSayisi());
            Console.WriteLine("Farklı girilen kelime sayısı:"+(liste[0].Split(' ').Count()+ liste[1].Split(' ').Count()+ liste[2].Split(' ').Count()));

           


             
        }




    }
}
