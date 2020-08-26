using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto{
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
           SetMarca(marca);
           SetModelo(modelo);
           SetCilindrada(cilindrada);
        }

        public Moto(){

        }

        public string GetMarca()
        {
            return this.Marca;
        }
        public void SetMarca(string marca)
        {
            this.Marca = marca;
        }

        public string GetModelo()
        {
            return this.Modelo;
        }
        public void SetModelo(string modelo)
        {
            this.Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return this.Cilindrada;
        }
        public void SetCilindrada(uint cilindrada) // uint => inteiro sem sinal
        {
            this.Cilindrada = cilindrada;      
        }
    }

    public class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

        }
    }
}