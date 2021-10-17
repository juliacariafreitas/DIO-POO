using System;
namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro1 = new Veiculo("ford", "ka", "prata", "flex");
            var carro2 = new Veiculo("volkswagen", "nivus", "cinza", "flex");

            carro1.ligar();
            carro1.acelerar();
            carro1.frear();
            carro1.desligar();

            carro2.ligar();
            carro2.acelerar();
            carro2.frear();
            carro2.desligar();
        }
    }
}
