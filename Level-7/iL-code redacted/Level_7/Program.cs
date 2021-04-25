using System;

namespace Level_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "1234560";
            Console.WriteLine("ENETR PASSWROD:");
            string inp = Console.ReadLine();
            if (inp == pass)
            {
                Console.WriteLine("Hello inturder!");
            }
        }
    }
}
