using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // F1 => Define apenas uma casa decimal
            Console.WriteLine(valor.ToString("C"));  // C  => Converte valor em moeda   
            Console.WriteLine(valor.ToString("P"));  // P  => Multiplica valor por 100 e colocar %
            Console.WriteLine(valor.ToString("#.##"));  // P  => Define duas casas decimais

            CultureInfo cultura = new CultureInfo("en-US");   // Trás formatações de cultura
            Console.WriteLine(valor.ToString("C0", cultura)); /* C0 => Define como moeda sem casas decimais
                                                               Local da moeda definida pela instancia cultura */

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // D10 => completa ( à esquerda )até o número ficar com 10 posições

        }
    }
}
