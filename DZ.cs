using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Level_4
{
    class Program
    {
        //1
        //static void Main(string[] args)
        //{
        //    int[,] m = {
        //    { 1, 2, 3 },
        //    { 4, 5, 4 },
        //    { 7, 8, 9 } };
        //    Console.Write("Элементы массива по диагонали:");
        //    for (int i = 0; i < m.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < m.GetLength(1); j++)
        //        {
        //            if (i == j)
        //                Console.Write($" {m[i, j]}");
        //        }
        //    }
        //}

        //    2
        //static void Main(string[] args)
        //{
        //    string[,] dir = {
        //    { "Андрнй", "+79119111111"},
        //    { "Иван", "+74993125313"},
        //    { "Алексей", "Leshia213_@mail.com"},
        //    { "Георгий", "Goshkin@mail.com"},
        //    { "Тимофей", "+74321551511"},
        //    { "Генадий", "+78521523213"},
        //    { "Александра", "Sahsa_sahsa_1023@mail.com"},
        //    { "Елизовета", "Lisa@gmail.com"}};

        //    Console.WriteLine("Справочник:");
        //    for (int i = 0; i < dir.GetLength(0); i++)
        //    {
        //        Console.WriteLine($"{dir[i, 0]}, {dir[i, 1]}");
        //    }
        //}

        //3
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите слово:");
        //    string word = Console.ReadLine();
        //    Console.WriteLine("Слово наоборот:");
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(word[i]);
        //    }
        //}

        //4
        //static void Main(string[] args)
        //{
        //    char[,] pole = {
        //    { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O'},
        //    { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
        //    { 'O', 'X', 'O', 'O', 'O', 'X', 'X', 'X', 'O', 'O'},
        //    { 'O', 'X', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O'},
        //    { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
        //    { 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'X'},
        //    { 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'X'},
        //    { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
        //    { 'O', 'X', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
        //    { 'O', 'O', 'O', 'O', 'X', 'X', 'X', 'X', 'O', 'O'}};
        //    Console.WriteLine("«Морской бой»:");

        //    for (int i = 0; i < pole.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < pole.GetLength(1); j++)
        //        {
        //            Console.Write($"{pole[i, j]} ");
        //        }
        //        Console.WriteLine();
        //    }
        //}




        //5
        //static void Main(string[] args)
        //{
        //    int[] array = { 1,2,3,4,5 };

        //    int value = 2;

        //    bool flag;
        //    if (value < 0)
        //    {
        //        flag = true;
        //        value = -value;
        //    }
        //    else
        //    {
        //        flag = false;
        //    }

        //    int lastIndex = array.Length - 1;
        //    for (int i = 0; i < value; i++)
        //    {
        //        int temp;
        //        if (flag)
        //        {
        //            temp = array[0];
        //        }
        //        else
        //        {
        //            temp = array[lastIndex];
        //        }

        //        for (int j = 0; j < lastIndex; j++)
        //        {
        //            if (flag)
        //            {
        //                array[j] = array[j + 1];
        //            }
        //            else
        //            {
        //                array[lastIndex - j] = array[lastIndex - j - 1];
        //            }
        //        }
        //        if (flag)
        //        {
        //            array[lastIndex] = temp;
        //        }
        //        else
        //        {
        //            array[0] = temp;
        //        }
        //    }

        //    array.ToList().ForEach(i => Console.WriteLine(i.ToString()));
        //}
    }
}

