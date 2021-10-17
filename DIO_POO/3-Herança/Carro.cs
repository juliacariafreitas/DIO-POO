using System;

namespace Heranca
{
    public class Carro : Veiculo
    {        
        public Carro(string marca, string modelo, string cor)
        : base(marca, modelo, cor)
        {
            Console.WriteLine("Eu sou um carro");
        }
    }
}
