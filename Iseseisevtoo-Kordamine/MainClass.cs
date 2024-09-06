using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//5. Variant

namespace Iseseisevtoo_Kordamine
{
    internal class MainClass
    {
        public static void Main(string[] args) 
        {
            //Ü 1. Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения гласных букв латинского алфавита в строку (не различая регистры).
            List<char> vokaalide_loetelu = new List<char>();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Sisestage sõna või lause: ");
            string tekst = Console.ReadLine();
            double protsent = Ulesanne_1.häälikute_loendamine(tekst, vokaalide_loetelu);
            Console.WriteLine("Vokaalide esinemise protsent: " + protsent + "%");
            if (vokaalide_loetelu.Count > 0)
            {
                Console.WriteLine("Vokaali: " + string.Join (", " ,vokaalide_loetelu));
            }
            else
            {
                Console.WriteLine("Vokaalide ei leitud");
            }
        }
    }
}
