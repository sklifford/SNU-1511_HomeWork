//Елка произвольного размера
using System;

namespace HomeWork1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 tier = 0;
            Int32 height = 0;
            Console.WriteLine("Для того чтоб увидеть елку введите");
            Console.Write("количество ярусов: ");
            String temp = Console.ReadLine();
            tier = Int32.Parse(temp);
            Console.Write("а так же высоту одного яруса: ");
            temp = Console.ReadLine();
            height = Int32.Parse(temp);
            int count = 1;
            int count2 = 1;
            int tier_temp = tier;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for(int x = 0; x<tier; x++)
            {
                for(int y = height; y>0; y--)
                {
                    for(int z = 0; z<(tier_temp+y-2); z++)
                    {
                        Console.Write(" ");
                    }
                    for(int z = 0; z<count2; z++)
                    {
                        Console.Write("@");
                    }
                    Console.Write("\n");
                    count2 += 2;
                }
                count += 2;
                count2 = count;
                tier_temp--;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int s = 0; s < tier; s++)
            {
                for (int i = 0; i < (height + tier - 3); i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("###");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
