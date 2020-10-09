/*
 * Să se scrie o aplicație consolă ce afișează câte numere pozitive sunt într-un șir de numere întregi dat.
Numerele se introduc câte unul pe linie, iar aplicația le va citi pe rând până cand utilizatorul scrie în loc de un număr caracterul x. 
Atunci când utilizatorul a tastat x aplicația știe că au fost introduse toate numerele din șir și afișează totalul numerelor pozitive.

Exemplu:

Pentru datele de intrare:
-4
3
-6
-7
x
La consolă se va afișa:
1
 */

using System;

namespace LoopsTest1Pb4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
      
            string inputData = Console.ReadLine();

            while (inputData != "x")
            {
                int n = Convert.ToInt32(inputData);

                if (n > 0 && n!=0)
                {
                    total++;
                }
                inputData = Console.ReadLine();
            }
            Console.WriteLine(total);
            Console.Read();
        }
    }
}
