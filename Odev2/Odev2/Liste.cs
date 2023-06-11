using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Liste<T>:List<T>
    {
        string[] kelime = new string[100];
        HashSet<string> hashset = new HashSet<string>();
        public void HashEkle(string kelime)
        {
            string[] kelimeAr = kelime.Split(' ');
            
            foreach (var k in kelimeAr)
            {
                if (k != "")
                {
                    hashset.Add(k);
                }
                
            }
            
        }
        public int kelimeSayisi()
        {
            return hashset.Count();
        }



    }
}
