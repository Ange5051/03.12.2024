using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Заполнение одномерного массива с клавиатуры и вывод на экран
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int size = GetSize();
            int[] array = Input(size);
            Output(array);
        }
        static int GetSize()
        {
            Console.Write("Введите одномерный массив: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка");
            }
            return size;
        }
        static int[] Input(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"array[{i}]");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]={array[i]}");
            }
        }
    }

}