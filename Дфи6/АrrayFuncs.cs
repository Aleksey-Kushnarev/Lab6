using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class ArrayFuncs
    {

        public static char[,] CreateArray(bool rnd = true)
        {
            int row = GetUserInt("Введите количество строк");
            int columns = GetUserInt("Введите количество cтолбцов");
            char[,] arr = new char[row, columns];
            if (rnd)
            {
                FillRandom(ref arr);
            }
            else
            {
                FillManually(ref arr);
            }
            return arr;
        }

        public static string PrintArray(char[,] arr)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sb.Append(arr[i, j] + " ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public static void FillRandom(ref char[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToChar(rnd.Next(0, 128));
                }
            }
        }

        public static void FillManually(ref char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = GetUserChar();
                }
            }
        }

        public static char GetUserChar()
        {
            bool isCorrect;
            char res;
            do
            {
                string input = Console.ReadLine();
                isCorrect = char.TryParse(input, out res);
                if (!isCorrect)
                {
                    Console.WriteLine("Введенное значение должно быть символом");
                }
                

            }
            while (!isCorrect);
            return res;
        }

        public static int GetUserInt(string message)
        {
            Console.WriteLine(message);
            bool isCorrect;
            int res;
            do
            {
                string input = Console.ReadLine();
                isCorrect = int.TryParse(input, out res);
                if (!isCorrect)
                {
                    Console.WriteLine("Введенное значение должно быть числом");
                }
                else if (res < 1)
                {
                    Console.WriteLine("Число должно быть больше 0");
                }
                
            } 
            while (!isCorrect);
            return res;
        }
    }
}
