using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do Aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            string status;

            if (nota >= 9.0)
            {
                status = ("Quandro de honra!");
            }
            else if (nota >= 7.0)
            {
                status = ("Aprovado");
            }
            else if (nota >= 5.0)
            {
                status = ("Aprovado");
            }
            else
            {
                status = ("Reprovado");
            }

            Console.WriteLine(status);
        }
    }
}
