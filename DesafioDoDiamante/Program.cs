using System;

namespace DesafioDoDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero, espacos, resultado;

            Console.WriteLine("Informe um número ímpar:");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero%2 != 0)
            {
                resultado = 1;
                espacos = (numero - 1) / 2;

                for (int i = 1; espacos > 0; i++)
                {

                    for (int j = 1; j <= espacos; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= resultado; j++)
                    {
                        Console.Write("X");
                    }

                    espacos--;
                    resultado += 2;
                    Console.WriteLine("");

                }

                for (int i = 1; resultado > 0; i++)
                {

                    for (int j = 1; j <= espacos; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= resultado; j++)
                    {
                        Console.Write("X");
                    }

                    espacos++;
                    resultado -= 2;
                    Console.WriteLine("");
                }
            }

        }
    }
}
