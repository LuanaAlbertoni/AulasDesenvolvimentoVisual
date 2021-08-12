using System;

namespace Atividade2Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 2");

            
            int fatorial = 1;

            for (int num = 1; num <= 10; num++)
            {
                fatorial *= num;
                Console.WriteLine("O fatorial de " + num + " é : " + fatorial);
            }
        }
    }
}
 
 