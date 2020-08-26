﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine().ToLower();

            bomComportamento = entrada == "s" || entrada == "sim";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
