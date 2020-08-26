using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Params
    {
        public static void Recepcionar(params string[] pessoas) // params = para um conjunto variado de parametros 
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine($"Olá {pessoa}");
            }
        }
        public static void Executar()
        {
            Recepcionar("Michael","Suélen","Silas","Mayara");
        }
    }
}