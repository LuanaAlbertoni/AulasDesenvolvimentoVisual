using System;

namespace _4_Condicionais
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 CONDICIONAIS");

            int idade = 16;
            //int numPessoas = 2;
            bool acompanhado = true;
            string mensagem;


                            //Exemplo 1

            if(idade >= 18 || acompanhado ==  true)
            {
                mensagem = "Entrada liberada";
            
            }
            else
            {
                mensagem = "Entrada proibida.Menor de 18 anos!";
             
            }
            Console.WriteLine(mensagem);


            //Exemplo 2
            //if (idade >= 18)
            //{
            //    Console.WriteLine("Entrada liberada");
            //}
            //else
            //{
            //    if (numPessoas >= 2)
            //    {
            //        Console.WriteLine("Entrada liberada. Número de pessoas: " + numPessoas)
            //    }
            //    else
            //    {
            //        Console.WriteLine("Entrada proibida. Menor de 18 anos!");
            //    }
            //}
        }
    }
}
