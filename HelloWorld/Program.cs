﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, select a greeting\n");
            Console.WriteLine("Option key A, Shakespeare");
            Console.WriteLine("Option key B, New York, New York");
            Console.WriteLine("Default (any other key), Southern American\n");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.A)
            {
                Console.WriteLine("\nHallo, welcometh to ye programme\n");
            }
            else if (info.Key == ConsoleKey.B)
            {
                Console.WriteLine("\nYo, sup holmes?\n");
            }
            else
            {
                Console.WriteLine("\nHowdy y'all!!\n");
            }

            string sentence;
            string myColor;

            Console.WriteLine("Please enter your Name:");
            sentence = Console.ReadLine();
            Console.WriteLine($"Hello, {sentence}, nice to meet you!");

            Console.WriteLine($"What is your favorite color, {sentence}?");
            myColor = Console.ReadLine();
            Console.WriteLine($"Would you like to have a {myColor} whale?");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
