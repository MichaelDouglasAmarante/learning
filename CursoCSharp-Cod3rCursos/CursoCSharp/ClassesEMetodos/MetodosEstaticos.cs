using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica{
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    public class MetodosEstaticos
    {
        public static void Executar()
        {
           var resultado = CalculadoraEstatica.Multiplicar(2,2);
           Console.WriteLine($"Resultado: {resultado}");

            
        }
    }
}