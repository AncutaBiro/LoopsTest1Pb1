/*Să se scrie o aplicație consolă ce calculează suma unui șir de numere întregi dat.
Numerele se introduc câte unul pe linie, iar aplicația le va citi pe rând până cand utilizatorul scrie în loc de un număr caracterul x. 
Atunci când utilizatorul a tastat x aplicația știe că au fost introduse toate numerele din șir și afișează suma lor.
Dacă primul lucru pe care îl introduce utilizatorul e caracterul x, aplicația va returna 0.

Exemplu:
Pentru datele de intrare:
2
5
-3
1
x
La consolă se va afișa:
5*/


using System;

namespace LoopsTest1Pb1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            const string V = "x";

            string inputData = Console.ReadLine();
            

        while (inputData != V) {

                int n = Convert.ToInt32(inputData);
                total += n;
                inputData = Console.ReadLine();
            
            }
        Console.WriteLine(total);
        Console.Read();
        }       
    }
}


