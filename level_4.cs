using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Level_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.");
            Console.WriteLine(GetFullName("Иван", "Иванович", "Иванов"));
            Console.WriteLine(GetFullName("Генадий", "Викторович", "Селиванов"));
            Console.WriteLine(GetFullName("Михаил", "Гаврилович", "Семенович"));
            Console.WriteLine(GetFullName("Дмитрий", "Стариков", "Михаилович"));
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("2.");
            Console.WriteLine("Введите несколько чисел через пробел: ");
            Console.WriteLine(SumUp(Console.ReadLine()));
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("3.");
            Console.WriteLine("Введит число месяца (от 1 до 12)");
            int num = 0;
            while (num < 1 || num > 12)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 1 || num > 12)
                {
                    Console.Write("Ошибка: введите число от 1 до 12");
                }
            }
            Seasons season = GetS(num);
            Console.WriteLine("Время года: " + GetSS(season));
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("4.");
            Console.Write("Введите число: ");
            int n = Fib(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Число Фибоначчи: " + n);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("5.");
            Normalise();
        }



        static string GetFullName(string n, string s, string p)
        {
            string full = $"{n} {s} {p}";
            return full;
        }

        static int SumUp(string inputLine)
        {
            int sum = 0;
            string num = "";
            for (int i = 0; i <= inputLine.Length; i++)
            {
                if (i == inputLine.Length || inputLine[i] == ' ')
                {
                    if (num != "")
                    {
                        sum += Convert.ToInt32(num);
                        num = "";
                    }
                }
                else
                {
                    num += inputLine[i];
                }
            }
            return sum;
        }

        enum Seasons
        {
            None = 0,
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }
        static Seasons GetS(int number)
        {
            Seasons season = Seasons.None;
            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    season = Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    season = Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    season = Seasons.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    season = Seasons.Autumn;
                    break;
            }
            return season;
        }
        static string GetSS(Seasons season)
        {
            string seasonStr = "";
            switch (season)
            {
                case Seasons.Winter:
                    seasonStr = "Зима";
                    break;
                case Seasons.Spring:
                    seasonStr = "Весна";
                    break;
                case Seasons.Summer:
                    seasonStr = "Лето";
                    break;
                case Seasons.Autumn:
                    seasonStr = "Осень";
                    break;
            }
            return seasonStr;
        }
        static int Fib(int num)
        {
            if (num < 2)
                return num;
            return Fib(num - 1) + Fib(num - 2);
        }
        static void Normalise()
        {
            Console.WriteLine("Изначальный вид");
            string original = " Предложение один    Теперь предложение два     Предложение три";
            Console.WriteLine(original);
            string redacted = Regex.Replace(original, " +", " ");
            StringBuilder redactednew = new StringBuilder(redacted);
            for (int i = redacted.Length - 1; i >= 0; i--)
            {
                if (redacted[i] >= 'A' && redacted[i] <= 'Я')
                {
                    redactednew[i - 1] = '.';
                    redactednew.Insert(i, ' ');
                }
            }
            redactednew.Remove(0, 2);
            redactednew.Append('.');
            Console.WriteLine("Обработанный вид");
            Console.WriteLine(redactednew);

        }
    }
}
