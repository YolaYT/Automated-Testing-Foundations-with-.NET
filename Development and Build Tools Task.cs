using System;
using System.Collections;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            int count = 0, MaxCount = 0;
            Console.WriteLine("Введите строку: ");
            str = Console.ReadLine();
            for(int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i - 1]) count++;
                else count = 1;
                if (count > MaxCount) MaxCount = count;
            }
            Console.WriteLine($"Максимальное количество неодинаковых последовательных символов в строке равно: {MaxCount} ");
        }
    }
}
