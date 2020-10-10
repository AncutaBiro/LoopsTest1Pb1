using System;

namespace CountOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, -1, 1 };

            int sum = 0;
            int firstIndex = 0;

            while (sum != 0)
            {
                sum += values[firstIndex];
                firstIndex++;
            }

            int secondIndex = 0;
            sum = 0;

            do
            {
                sum += values[secondIndex];
                secondIndex++;
            } while (sum != 0);

            int thirdIndex = 0;
            sum = 0;

            for (thirdIndex = 0; thirdIndex < values.Length; thirdIndex++)
            {
                sum += values[thirdIndex];
            }



          
        }
    }
}
