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
        public static double häälikute_loendamine(string tekst, List<char> vokaalide_loetelu)
        {
            string vokaali = "aoeiuy";
            int vokaali_loendama = 0;
            vokaalide_loetelu = new List<char>();
            foreach (char sümbol in tekst)
            {
                if (vokaali.Contains(sümbol))
                {
                    vokaali_loendama += 1;
                    vokaalide_loetelu.Add(sümbol);
                }
            }
            if (tekst.Length == 0)
            {
                return 0;

            }
            double protsent = (double)vokaali_loendama/tekst.Length * 100;
            return protsent; 
        }
    }
}
