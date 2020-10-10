/*
Se dă un număr N pe prima linie, urmat, pe liniile următoare de o listă de numere. Lungimea listei de numere e variabilă. 
Se citește de la tastatură, câte un număr pe linie, până utilizatorul introduce caracterul 'x'.

Să se scrie o aplicație consolă ce afișează produsul dintre numărul N și numărul lui de apariții în listă. 
De exemplu, dacă N apare în listă de 4 ori la consolă se va afișa rezultatul expresiei N * 4.

Sugestie: Folosiți execuția pas cu pas pentru a localiza și fixa eroarea din proiectul atașat.

Exemplu:

Pentru datele de intrare:

3
1
2
3
2
3
3
x
La consolă se va afișa:

9
 */

using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
                int numberToFind = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                string line = Console.ReadLine();

                while (line != "x")
                {
                    int number = Convert.ToInt32(line);
                    if (number == numberToFind)
                    {
                        count++; 
                    }
                line = Console.ReadLine();
                }

                Console.WriteLine(numberToFind * count);
                Console.ReadLine();
            }
        }
    }

