//рисование цифр
using System;

namespace HomeWork1_3
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для отображения его на экране: ");
            String number = Console.ReadLine();
            int count = number.Length;
            int digit;
            char symbol;
            Console.WriteLine();
            //_____________________прорисовка_________________________
            for(int i = 0; i < 8; i++)
            {
                for(int d = 0; d < count; d++)
                {
                    symbol = number[d];
                    digit = int.Parse(char.ToString(symbol));
                    switch (digit)
                    {
                        case 1:
                            {
                                switch (i)
                                {
                                    case 0:
                                        Console.Write("  {0}   ", digit);
                                        break;
                                    case 1:
                                        Console.Write(" {0}{0}   ", digit);
                                        break;
                                    case 2:
                                        Console.Write("{0} {0}   ", digit);
                                        break;
                                    case 3:
                                    case 4:
                                    case 5:
                                    case 6:
                                        Console.Write("  {0}   ", digit);
                                        break;
                                    case 7:
                                        Console.Write("{0}{0}{0}{0}{0} ", digit);
                                        break;
                                }
                                break;
                            }
                        case 2:
                            {
                                switch (i)
                                {
                                    case 0:
                                        Console.Write(" {0}{0}{0}  ", digit);
                                        break;
                                    case 1:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                    case 2:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                    case 3:
                                        Console.Write("   {0}  ", digit);
                                        break;
                                    case 4:
                                        Console.Write("  {0}   ", digit);
                                        break;
                                    case 5:
                                        Console.Write(" {0}    ", digit);
                                        break;
                                    case 6:
                                        Console.Write("{0}     ", digit);
                                        break;
                                    case 7:
                                        Console.Write("{0}{0}{0}{0}{0} ", digit);
                                        break;
                                }
                                break;
                            }
                        case 3:
                            {
                                switch (i)
                                {
                                    case 0:
                                        Console.Write(" {0}{0}{0}  ", digit);
                                        break;
                                    case 1:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                    case 2:
                                        Console.Write("    {0} ", digit);
                                        break;
                                    case 3:
                                        Console.Write("  {0}{0}  ", digit);
                                        break;
                                    case 4:
                                    case 5:
                                        Console.Write("    {0} ", digit);
                                        break;
                                    case 6:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                    case 7:
                                        Console.Write(" {0}{0}{0}  ", digit);
                                        break;
                                }
                                break;
                            }
                        case 4:
                            {
                                switch (i)
                                {
                                    case 0:
                                    case 5:
                                    case 6:
                                    case 7:
                                        Console.Write("   {0}  ", digit);
                                        break;
                                    case 1:
                                        Console.Write("  {0}{0}  ", digit);
                                        break;
                                    case 2:
                                        Console.Write(" {0} {0}  ", digit);
                                        break;
                                    case 3:
                                        Console.Write("{0}  {0}  ", digit);
                                        break;
                                    case 4:
                                        Console.Write("{0}{0}{0}{0}{0} ", digit);
                                        break;
                                }
                                break;
                            }

                        case 5:
                            {
                                switch (i)
                                {
                                    case 0:
                                        Console.Write("{0}{0}{0}{0}{0} ", digit);
                                        break;
                                    case 1:
                                    case 2:
                                        Console.Write("{0}     ", digit);
                                        break;
                                    case 3:
                                        Console.Write("{0}{0}{0}{0}  ", digit);
                                        break;
                                    case 4:
                                    case 5:
                                        Console.Write("    {0} ", digit);
                                        break;
                                    case 6:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                    case 7:
                                        Console.Write(" {0}{0}{0}  ", digit);
                                        break;
                                }
                                break;
                            }
                        case 6:
                            {
                                switch (i)
                                {
                                    case 0:
                                    case 7:
                                        Console.Write(" {0}{0}{0}  ", digit);
                                        break;
                                    case 1:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                    case 2:
                                        Console.Write("{0}     ", digit);
                                        break;
                                    case 3:
                                        Console.Write("{0}{0}{0}{0}  ", digit);
                                        break;
                                    case 4:
                                    case 5:
                                    case 6:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                }
                                break;
                            }
                        case 7:
                            {
                                switch (i)
                                {
                                    case 0:
                                        Console.Write("{0}{0}{0}{0}{0} ", digit);
                                        break;
                                    case 1:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                    case 2:
                                        Console.Write("   {0}  ", digit);
                                        break;
                                    case 3:
                                        Console.Write("  {0}   ", digit);
                                        break;
                                    case 4:
                                    case 5:
                                    case 6:
                                    case 7:
                                        Console.Write(" {0}    ", digit);
                                        break;
                                }
                                break;
                            }
                        case 8:
                            {
                                switch (i)
                                {
                                    case 0:
                                    case 3:
                                    case 7:
                                        Console.Write(" {0}{0}{0}  ", digit);
                                        break;
                                    case 1:
                                    case 2:
                                    case 4:
                                    case 5:
                                    case 6:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                }
                                break;
                            }
                        case 9:
                            {
                                switch (i)
                                {
                                    case 0:
                                    case 7:
                                        Console.Write(" {0}{0}{0}  ", digit);
                                        break;
                                    case 1:
                                    case 2:
                                    case 6:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                    case 3:
                                        Console.Write(" {0}{0}{0}{0} ", digit);
                                        break;
                                    case 4:
                                    case 5:
                                        Console.Write("    {0} ", digit);
                                        break;
                                }
                                break;
                            }
                        case 0:
                            {
                                switch (i)
                                {
                                    case 0:
                                    case 7:
                                        Console.Write(" {0}{0}{0}  ", digit);
                                        break;
                                    case 1:
                                    case 2:
                                    case 3:
                                    case 4:
                                    case 5:
                                    case 6:
                                        Console.Write("{0}   {0} ", digit);
                                        break;
                                }
                                break;
                            }
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
