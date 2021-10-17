using System;

namespace Heranca
{
    public class Aviao : Veiculo
    {
        public int _numeroDeTurbinas { get; set; }
        
        public Aviao(string marca, string modelo, string cor, int numeroDeTurbinas)
        : base(marca, modelo, cor)
        {
            Console.WriteLine("Eu sou um avião");
            _numeroDeTurbinas = numeroDeTurbinas;
        }

    }
}
