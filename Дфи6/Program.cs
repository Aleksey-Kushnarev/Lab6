using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            PrintHelpMessage();
            do
            {
                key = Console.ReadKey();
                string inf = key.Key.ToString();
                Console.WriteLine();
                switch (inf)
                {
                    case "D0":
                        PrintHelpMessage();
                        break;
                    case "D1":
                        //Console.WriteLine("1");
                        WorkWithArrays();
                        break;
                    case "D2":
                        Console.WriteLine("2");
                        //WorkWithStrings();
                        break;

                    case "Escape":
                        break;

                    default:
                        Console.WriteLine("Такой команды не сущействует. Для вывода списка команд введите 0");
                        break;
                }
            } while (key.Key != ConsoleKey.Escape);


        }

        public static void PrintHelpMessage()
        {
            Console.WriteLine("0 - Вывод списка команд\n" +
                              "1 - Работа с массивами\n" +
                              "2 - Работа со строками\n" +
                              "Esc - Выход");
        }


        public static void WorkWithArrays()
        {
            ArrayFuncs arrayFuncs = new ArrayFuncs();
            char[,] arayChars;
            ConsoleKeyInfo key;
            PrintHelpMessageForArray();
            do
            {
                key = Console.ReadKey();
                string inf = key.Key.ToString();
                Console.WriteLine();
                switch (inf)
                {
                    case "D0":
                        PrintHelpMessageForArray();
                        break;
                    case "D1":
                        
                        Console.WriteLine("1 - Заполнить массив вручную\n" +
                                          "2 - Заполнить массив случайными числами");
                        string methodCreating = Console.ReadLine();
                        switch (methodCreating)
                        {
                            case "1":
                                bool rnd = false;
                                arayChars = ArrayFuncs.CreateArray(rnd);
                                Console.WriteLine(ArrayFuncs.PrintArray(arayChars));
                                break;

                            case "2":
                                arayChars = ArrayFuncs.CreateArray();
                                Console.WriteLine(ArrayFuncs.PrintArray(arayChars));
                                break;

                            default:
                                Console.WriteLine("Команда нераспознана");
                                break;
                        }
                        
                        
                        
                        break;
                    case "D2":
                        Console.WriteLine("2");
                        //WorkWithStrings();
                        break;

                    case "Escape":
                        break;

                    default:
                        Console.WriteLine("Такой команды не сущействует. Для вывода списка команд введите 0");
                        break;
                }
            } while (key.Key != ConsoleKey.Escape);
        }
        public static void PrintHelpMessageForArray()
        {
            Console.WriteLine("0 - Вывод списка команд\n" +
                              "1 - Cоздать массив\n" +
                              "2 - Удалить строки, в которых нет цифр\n" +
                              "Esc - Выход");
        }
    }
}
