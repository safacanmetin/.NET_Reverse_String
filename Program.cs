using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string you want to reverse:");
            string text = Console.ReadLine();

            string reversedText ="";

            for (int i = text.Length - 1; i >= 0; i--) {
                reversedText += text[i];
            }
            Console.WriteLine("Reversed text: " + reversedText);
        }

    }
}