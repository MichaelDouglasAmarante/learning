using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);


            // Conversões que podem gerar perda de informação tem que ser explicitas 
            double nota = 9.7;
            int notaTruncada = (int) nota; // Conversão de tipos ( casting )
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString); // Convert => classe interna 
            Console.WriteLine($"Resultado: {idadeInteiro}");

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); // TryParse => tentar fazer um Parse | Pega palavra convertido e coloca em numero
            Console.WriteLine($"Resultado {numero1}");

            //Otimizando o bloco do primeiro número 
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); // TryParse => tentar fazer um Parse | Pega palavra convertido e coloca em numero
            Console.WriteLine($"Resultado {numero2}");

        }
    }
}
