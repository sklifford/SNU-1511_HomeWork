//Показать на экране лесенку из заданого пользователем количества ступеней

using System;

namespace HomeWork1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 Num = 0;
            Int32 Step = 2;
            Int32 Res = 0;
            Console.WriteLine("Укажите количество ступеней для прорисовки лестницы");
            String temp = Console.ReadLine();
            Num = Int16.Parse(temp);
            for (Int32 i = 0; i < Num; i++)
            {
                Res = Step * i;
                for (Int32 j = 0; j < Res; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("***");
                for (Int32 j = 0; j < Res; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("  *");
            }
            for (Int32 j = 0; j < Res + Step; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("***");
        }
    }
}
