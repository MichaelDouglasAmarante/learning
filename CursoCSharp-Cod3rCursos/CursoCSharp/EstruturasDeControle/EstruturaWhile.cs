using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Digite um número: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasRestantes--;

                if (palpite == numeroSecreto)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Parabéns, você acertou! Encontrado em {tentativasRestantes + 1} tentativa(s)!");
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine($"Menor... Tente novamente. ( Tentativas restantes: {tentativasRestantes}");
                }
                else
                {
                    Console.WriteLine($"Maior... Tente novamente. ( Tentativas restantes: {tentativasRestantes}");
                }
               
            }

        }
    }
}
