using System;

class Program
{
 static void Main(string[] args)
 {
            int[] numbers = { 2, 3, 5, 7, 25, 15, 9, 30 };
            string[] result = new string[8];
        
   for (int i = 0; i < numbers.Length; i++)
                {
                   result[i] = "";
            
                   if (numbers[i] % 3 == 0)
                         result[i] += "Fizz";
            
                   if (numbers[i] % 5 == 0)
                         result[i] += "Buzz";
           
                   if (result[i] == "")
                          result[i] += numbers[i].ToString();
                }
        
    for (int i = 0; i < result.Length; i++)
                    Console.WriteLine(result[i]);
      
   Console.Read();
          }
    }