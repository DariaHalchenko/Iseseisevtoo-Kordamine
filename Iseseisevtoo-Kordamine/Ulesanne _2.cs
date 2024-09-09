using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtoo_Kordamine
{
    internal class Ulesanne__2
    {
        public static int[] Arvude_massiv(int N)
        {
            Random random = new Random();
            Console.WriteLine(N);
            int[] arvud = new int[N];
            
            //Massiivi täitmine juhuarvudega 
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = random.Next(-150, 151);
           } 
            return arvud;
        }
        //Funktsioon arvutab massiivi elementide arvu vahemikus -100 kuni +100
        public static int Elementide_arv (int[] arvud, int min, int max)
        {
            int elemendid  = 0;
            
            ////Läbime iga massiivi elemendi, kui element satub vahemikku, siis arvesti suureneb 
            foreach (int arv in arvud)
            {
                if (arv >= min && arv <= max)
                {
                    elemendid +=1 ;
                }
            }
            return elemendid ;
        }
    }
}
