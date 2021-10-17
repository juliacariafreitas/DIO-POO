using System;

namespace Encapsulamento
{
    class Veiculo : IVeiculo 
    {
        public string _marca { get; set; }
        public string _modelo { get; set; }
        public string _cor { get; set; }
        public string _combustivel { get; set; }

        public Veiculo()
        {
        }

        public Veiculo(string marca, string modelo, string cor, string combustivel)
        {
            _marca = marca;
            _modelo = modelo;
            _cor = cor;
            _combustivel = combustivel;
        }

        public void ligar()
        {
            processoLigar();
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

        private void processoLigar()
        {
            Console.WriteLine($"    -- Colocar chave na ignição");
            Console.WriteLine($"    -- Virar a chave");
        }
    }
}
