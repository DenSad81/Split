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
        char separator = ' ';
        string[] words = sentence.Split(separator);

        Console.WriteLine($"Предложение: {sentence}");
        Console.WriteLine();

        for (int i = 0; i < words.Length; i++)
            Console.WriteLine($"Слово: {words[i]}");

        Console.WriteLine();
    }
}