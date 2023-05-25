using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health;
            int mana;
            bool isProgrammWorks = true;

            while (isProgrammWorks)
            {
                Console.Write("Введите число, на которое изменится жизнь в процентах: ");
                health = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число, на которое изменится мана в процентах: ");
                mana = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(0, 3);
                DrawBar(health, ConsoleColor.Red);
                Console.SetCursorPosition(0, 4);
                DrawBar(mana, ConsoleColor.Blue);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void DrawBar(float persent, ConsoleColor color)
        {
            int maxValue = 10;
            int minValue = 0;
            float cells = 10;
            float allPersent = 100;
            persent = persent / allPersent * cells;

            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.Write('[');
            Console.BackgroundColor = color;

            for (int i = 0; i < persent; i++)
            {
                if (persent <= maxValue)
                    Console.Write('#');
            }
            Console.BackgroundColor = defaultColor;

            for (float i = persent; i < maxValue; i++)
            {
                if (persent >= minValue)
                    Console.Write('_');
            }
            Console.Write(']');
        }
    }
}
