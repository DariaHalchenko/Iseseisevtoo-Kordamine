using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtoo_Kordamine
{
    internal class Ulesanne_1
    {
        public static double häälikute_loendamine(string tekst)
        {
            string vokaalid = "aeiouy";
            int vokaali_loendama = 0;

            tekst = tekst.ToLower(); // Toome teksti alamregistri juurde

            //Käib läbi iga tekstisümboli, et leida täishäälikuid ja suurendada loendurit 
            for (int i = 0; i < tekst.Length; i++)
            {
                char sümbol = tekst[i];
                if (vokaalid.Contains(sümbol))
                {
                    vokaali_loendama +=1;
                }
            }
            //Kui tühi rida, siis tagasi 0
            if (tekst.Length == 0)
            {
                return 0;
            }
            //Arvutame teksti pikkusest välja häälte protsendi
            double protsent = (double)vokaali_loendama / tekst.Length * 100;
            return protsent; 
        }
    }
}
