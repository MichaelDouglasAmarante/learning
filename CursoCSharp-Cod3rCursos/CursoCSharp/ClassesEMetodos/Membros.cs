using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Michael";
            pessoa1.Idade = 21;

            pessoa1.ApresentarNoConsole();
        }
    }
}
