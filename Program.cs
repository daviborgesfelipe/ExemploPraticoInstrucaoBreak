using System;

namespace ExemploPraticoInstrucaoBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            
            while (true)
            {
                while (true)
                {
                    Console.Write("Deseja continuar? [s] sim ou [n] não: ");
                    opcao = Console.ReadLine();

                    if (opcao == "n")
                    {
                        break;
                    }
                }
                Console.WriteLine("Laço externo");    
            }
            
        }
    }
}
