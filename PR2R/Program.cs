using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace PR2R
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход из программы");
            Console.WriteLine(" ");
            Console.WriteLine("Выберите программу: ");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                Igra();
            else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                Tabl();
            else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                Delitel();
            else if (key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4)
                Environment.Exit(0);
        }
        static void Igra()
        {
            Console.Clear();
            Console.WriteLine("Угадай число от 0 до 100");
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Random c = new Random();
            int r = c.Next(0, 100);
            while (a != r)
            {
                string num = (a > r) ? "Цифера поменьше" : "Циферка побольше";
                Console.WriteLine(num);
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Верно!");
            Console.WriteLine("\n");
            Main();
        }
        static void Tabl()
        {
            Console.Clear();
            Console.WriteLine("Таблица умножения");
            int[,] j = new int[10, 10];
            for (int column = 1; column < 10; column++)
            {
                for (int line = 1; line < 10; line++)
                {
                    j[column, line] = column * line;
                    Console.Write(j[column, line] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Main();
        }
        static void Delitel()
        {
            Console.Clear();
            Console.WriteLine("Делитель числа");
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int l = 1; l <= n; l++)
            {
                if (n % l == 0)
                    Console.Write(l + " ");
            }
            Console.WriteLine("\n");
            Main();
        }
    }
}