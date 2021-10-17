using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Carro("Ford", "Ka", "Prata");
            Veiculo aviao = new Aviao("Airbus", "A320", "Branco", 4);

            carro.ligar();
            carro.acelerar();
            carro.frear();
            carro.desligar();

            Console.WriteLine();

            aviao.ligar(); 
            aviao.acelerar();
            aviao.frear();
            aviao.desligar();
        }
    }
}
