using System;
using System.IO;

namespace level_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Text();
            Time();
            Byte();

            //1
            static void Text()
            {
                Console.WriteLine("1 Задание");
                string text = "text.txt";
                Console.Write("Ввдети информацию в файл с текстом:");
                string n = Console.ReadLine();
                File.WriteAllText(text, n);
                Console.WriteLine($"Файл с текстом {n}");
                File.AppendAllText(text, Environment.NewLine);
                Console.Write($"Ввдети дополнительную информацию:");
                File.AppendAllText(text, Console.ReadLine());
                Console.Write("Полученный текст:");
                Console.WriteLine(File.ReadAllText(text));
                Console.WriteLine("");
            }

            static void Time()
            {
                //2
                Console.WriteLine("2 Задание");
                string text2 = "startup.txt";
                string d = Convert.ToString(DateTime.Now);
                File.AppendAllText(text2, d);
                File.AppendAllText(text2, Environment.NewLine);
                Console.WriteLine("Текущее время добавлено в файл");
                Console.WriteLine("Прочитать файл Y/N:");
                string a = Console.ReadLine();
                if (a == "Y")
                {
                    Console.WriteLine(File.ReadAllText(text2));
                }
            }

            static void Byte()
            {
                //3
                Console.WriteLine("3 Задание");
                const string file = "byte.bin";
                Console.Write("Введите число от 0 до 255: ");
                var input = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var bar = new byte[input.Length];
                for (var i = 0; i < bar.Length; i++)
                {
                    if (!byte.TryParse(input[i], out var num))
                    {
                        Console.WriteLine($"Данное число: {input[i]} - не правильные число");
                        return;
                    }
                    bar[i] = num;
                }
                var bw = new BinaryWriter(File.OpenWrite(file));
                bw.Write(bar);
            }


            //4
            Console.WriteLine(" ");
            Console.WriteLine("4 Задание");
            Employee[] employees = {
                new Employee("Дмитрий", "Луков", "123@mail.ru", "Повар", 125000, 1955),
                new Employee("Иван", "Стариков", "321@mail.ru","Другой повар", 68000, 1983),
                new Employee("Андрей", "Рабков", "213@mail.ru", "Врач", 121212, 1969),
                new Employee("Константин", "Трутин", "123312@mail.ru", "Продавец", 89562, 1925)
            };

            Console.WriteLine("Работники старше 40");

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].getAge() > 40)
                    Console.WriteLine(employees[i].getinfo());
            }

            Console.WriteLine("-----------------------------Все работники---------------------------");

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].getinfo());
            }

            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
