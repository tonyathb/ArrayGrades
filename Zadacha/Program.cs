using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class Program
    {
        public static void MaxOcenkaNaUchenik(float[] ocenki9d)
        {
            float maxOcenka = 0;
            for (int i = 0; i < ocenki9d.Length; i++)
            {
                if (ocenki9d[i] > maxOcenka)
                {
                    maxOcenka = ocenki9d[i];
                    maxOcenka = i + 1;
                }

            }
            //return maxOcenka;                             // Ne e palnoto reshenie na zadachata!!!

        }
        public static void DobavenaOcenka(float[] ocenki9d)
        {
            float[] dobavenaOcenka = new float[ocenki9d.Length];

            for (int i = 0; i < ocenki9d.Length; i++)
            {
                if (ocenki9d[i] < 5.50)
                {
                    Console.WriteLine(ocenki9d[i] + 1);
                }
            }
        }
        private static void InputElements(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Vavedi ocenki na uchenik nomer {i + 1}: ");
                float ocenka=float.Parse(Console.ReadLine());
                if (ocenka<2 || ocenka>6)
                {
                    i--;
                    continue;
                }
                array[i] = ocenka;
            }
        }
        private static void PrintElements(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
        //б.
        private static  float NameriOcenka(int index, float[] array) {
            float result = 0.0f;

            result = array[index-1];

            return result;
        }
        //г.
        private static int NameririMAXOcenka(float[] array)
        {
            float maxElement = 0.0f;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        //e.
        private static void Increment(float[] array)
        {
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] > 5)
                {
                    continue;
                }
                array[k]++;
            }
        }

        static void Main(string[] args)
        {
            //0. DECLARATION
            float[] ocenki9d = new float[5];
            //1.Input ==> а).
            InputElements(ocenki9d);

            //2.Work
            Console.Write("Na koj N ocenkata? ");
            byte nomer = byte.Parse(Console.ReadLine());
            //в.
            Console.WriteLine($"Ocenkata na nomer {nomer} e {NameriOcenka(nomer,ocenki9d)}");

            //г.
            int maxNomer = NameririMAXOcenka(ocenki9d);
            Console.WriteLine($"MAX ocenka e {ocenki9d[maxNomer]} na nomer {maxNomer+1}");

            //д.
            Console.WriteLine($"AVG= {ocenki9d.Average()}");

            //3.Print ==> е).
            Increment(ocenki9d);
            PrintElements(ocenki9d);
        }     
    }
}
