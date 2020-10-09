
/*
Să se scrie o aplicație consolă ce calculează 2 la puterea N. N este un număr întreg, mai mare sau egal decât 0, citit de la tastatură.
Exemplu:
Pentru datele de intrare:
5
La consolă se va afișa:
32
 */

using System;

namespace LoopsTest1Pb3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int two = 2;

            string inputData = Console.ReadLine();
            int n = Convert.ToInt32(inputData);

            while (n >= 0)
            {
                int result = (int) Math.Pow(two, n);
                Console.WriteLine(result);
                Console.Read();
                break;
            }

        }
    }
}
