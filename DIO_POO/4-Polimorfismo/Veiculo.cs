using System;

namespace Polimorfismo
{
    class Veiculo : IVeiculo
    {
        public string _marca { get; set; }
        public string _modelo { get; set; }
        public string _cor { get; set; }

        public Veiculo()
        {
        }

        public Veiculo(string marca, string modelo, string cor)
        {
            _marca = marca;
            _modelo = modelo;
            _cor = cor;
        }

        public void ligar()
        {
            Console.WriteLine($"- O veiculo {_marca} {_modelo} está ligado.");
        }

        public void acelerar()
        {
            Console.WriteLine($"- O veiculo {_marca} {_modelo} acelerou.");
        }

        public void frear()
        {
            Console.WriteLine($"- O veiculo {_marca} {_modelo} freou.");
        }

        public void desligar()
        {
            Console.WriteLine($"- O veiculo {_marca} {_modelo} desligou.");
        }
    }
}
