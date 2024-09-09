using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtoo_Kordamine
{
    internal class Ulesanne_3
    {
        //arvutab tulumaksu, tagastades 22% palgast 
        public const double Maksumäär = 0.22; 

        public double Tulumaksu_arvutamine(double palk)
        {
            double maks = palk * Maksumäär;
            return maks;
        }
    }
}
