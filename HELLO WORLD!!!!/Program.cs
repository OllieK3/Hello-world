using System;
using System.Collections.Generic;
namespace HELLO_WORLD____
{
    class Program
    {
        static double Height;
        static int age;
        static string message = "My age is ";
        static string HeightMessage = "My height is ";
        static void Main(string[] args)
        {
           List<int> numberList = new List<int>() { 6, 12, 18, 24 };
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }

          List<string> WordList = new List<string>() { "The funny business", "The monkey business" };
          for (int i = 0; i <WordList.Count; i++)

            {
                Console.WriteLine(WordList[i]);
            }

            age = 16;
            Height = 1.1;
            Console.WriteLine(message + age);
            Console.WriteLine(HeightMessage + Height);
            Console.ReadKey();
            


            
        }
    }
}
