using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Раз два три четыре пять";
            string[] arrayOfWords = sentence.Split(' ');

            Console.WriteLine($"Предложение: {sentence}");
            Console.WriteLine();

            for (int i = 0; i < arrayOfWords.Length; i++)
                Console.WriteLine($"Слово: {arrayOfWords[i]}");

            Console.WriteLine();
        }
    }