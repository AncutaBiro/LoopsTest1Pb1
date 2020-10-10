using System;

namespace testQuiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string result = "";

            while (line != "gata")
            {
                int number = Convert.ToInt32(line);
                result += number * 2 + " ";
                line = Console.ReadLine();

            }
            Console.WriteLine(result);
        }
    }
}

