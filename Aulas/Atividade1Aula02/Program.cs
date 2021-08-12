using System;

namespace Atividade1Aula02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Atividade 1");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
