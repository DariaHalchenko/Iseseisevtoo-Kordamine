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
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Sisestage sõna või lause: ");
            string tekst = Console.ReadLine();
            double protsent = Ulesanne_1.häälikute_loendamine(tekst);
            Console.WriteLine("Vokaalide esinemise protsent: " + protsent + "%");
            
            //Ü 2. Задан массив действительных чисел из N элементов (используйте генератор случайных чисел). Определить количество элементов, значения которых находятся в диапазоне от -100 до +100.
            Console.Write("Sisesta elementide arv: ");
            int N = int.Parse(Console.ReadLine());
            int[] arvud = Ulesanne__2.Arvude_massiv(N);
            Console.WriteLine("Toimivate numbrite massiiv N-elementidest: ");
            foreach (int arv in arvud)
            {
                Console.Write(arv + " ");
            } 
            int elemendid = Ulesanne__2.Elementide_arv(arvud, -100, 100);
            Console.WriteLine("Elemendid vahemikus -100 kuni 100: " + elemendid);

            //Ü 3. Написать подпрограмму, которая вычисляет подоходный налог для введеной пользователем зарплаты.
            try
            {
                Console.Write("Milline on teie palk? ");
                double palk = double.Parse(Console.ReadLine());
                if (palk < 0)
                {
                    Console.WriteLine("Viga");
                    return;
                }
                Ulesanne_3 ulesanne_3 = new Ulesanne_3();
                double maks = ulesanne_3.Tulumaksu_arvutamine(palk);
                Console.WriteLine("Teie tulumaks on:" + maks + "евро");
            }
            catch (FormatException)
            {
                Console.WriteLine("Sisesta positiivne arv");
            }
        }    
    }
}
