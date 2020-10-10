/*
 Să se scrie o aplicație consolă ce citește de la tastatură o listă de numere până când suma lor ajunge la o anumită limită dată.
Pe prima linie se dă limita, iar pe următoarele linii urmează lista de numere ce trebuie adunate. Programul se va opri din citit când suma numerelor 
introduse până atunci depășește limita și va afișa ultima sumă ce nu depășea limita, precum și de căte numere a fost nevoie pentru a o calcula.
Sugestie: Folosiți execuția pas cu pas pentru a localiza și fixa eroarea din proiectul atașat.

Exemplu:

Pentru datele de intrare:

10
2
3
2
6
La consolă se va afișa:

7 3
 */

using System;

namespace CappedSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumLimit = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            int number = 0;

            while (sum < sumLimit)
            {
              number = Convert.ToInt32(Console.ReadLine());
              sum += number;
              count++;
            }

            Console.WriteLine((sum - number )+ " " + (count-1));
            Console.ReadLine();
        
        }
    }
}
