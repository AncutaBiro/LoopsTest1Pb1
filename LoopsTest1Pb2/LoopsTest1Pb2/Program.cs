
/*Să se scrie o aplicație consolă ce determină cel mai mare element dintr-un șir de numere întregi dat.
Numerele se introduc câte unul pe linie, iar aplicația le va citi pe rând până cand utilizatorul introduce numărul 0. 
Când s-a introdus numărul 0 aplicația știe că au fost introduse toate numerele din șir și îl afișează pe cel mai mare dintre ele.

Numărul 0 face și el parte din șir și dacă e cel mai mare număr introdus de utilizator atunci aplicația va returna 0.

Exemplu:

Pentru datele de intrare:

24
1
-3
3
-1
0
La consolă se va afișa:

24
 */

using System;

namespace LoopsTest1Pb2
{
    class Program
    {
        static void Main(string[] args)
        {
                string inputData = Console.ReadLine();
                int n = Convert.ToInt32(inputData);

                int max = 0;

                while (n!= 0)
                {
                max = max > n ? max : n;    
                inputData = Console.ReadLine();
                n = Convert.ToInt32(inputData);
        }
                Console.WriteLine(max);
                Console.Read();
        }
        
    }
}
