using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Level_6
{
    class Task_m
    {
        private int Scan(Prog[] a, int id)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Id == id)
                {
                    Console.WriteLine($"Процесса {a[i].Name} ||ID:  {a[i].Id}");
                    return i;
                }
            }
            return -1;
        }

        private void Еxit(Prog[] a, int b, int i)
        {
            switch (i)
            {
                case 1:
                    Process[] kill = Process.GetProcessesByName(a[b].Name);
                    foreach (Process worker in kill)
                    {
                        worker.Kill();
                    }
                    break;
                case 2:
                    Process[] kill2 = Process.GetProcessesByName(a[b].Name);
                    foreach (Process worker in kill2)
                    {
                        worker.CloseMainWindow();
                    }
                    break;
            }
        }
        public void GetProcess()
        {
            Prog[] ProgramMass = new Prog[Process.GetProcesses().Length];
            int a = 0;
            foreach (Process pro in Process.GetProcesses())
            {
                ProgramMass[a] = new Prog(pro.Id, pro.ProcessName);
                a++;
            }

            for (int i = 0; i < ProgramMass.Length; i++)
            {
                Console.WriteLine($"Процесса {ProgramMass[i].Name} ||ID:  {ProgramMass[i].Id}");
            }
            Console.Write("Введите ID процесса, который хотите закрыть: ");

            int id = Convert.ToInt32(Console.ReadLine());

            int innum = Scan(ProgramMass, id);
            if (innum == -1) Console.WriteLine("ID не найден");
            Console.Write("Завершить процесс: 1 жестко / 2 мягко: ");
            int exit = Convert.ToInt32(Console.ReadLine());
            Еxit(ProgramMass, innum, exit);
            Console.ReadKey();
        }
    }
}
