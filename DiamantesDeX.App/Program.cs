using System.Diagnostics;

namespace DiamantesDeX.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, espaco, x;
            Console.WriteLine("Insira um número ímpar: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 != 0)
            {
                x = 1;
                espaco = (numero - 1) / 2;
                for (int linha = 1; espaco > 0; linha++)
                {
                    
                    for (int k = 1; k <= espaco;k++)
                    {
                        Console.Write(" ");
                    }
                    
                    for (int k = 1; k <= x; k++)
                    {
                        Console.Write("x");
                    }
                    espaco--;
                    x += 2;
                    Console.WriteLine();
                }

                
                for (int linha = 1; x > 0; linha++)
                {

                    
                    for (int k = 1; k <= espaco; k++)
                    {
                        Console.Write(" ");
                    }

                    
                    for (int k = 1; k <= x; k++)
                    {
                        Console.Write("X");
                    }
                    espaco++;
                    x -= 2;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não é ímpar!");
            }
        }
    }

}