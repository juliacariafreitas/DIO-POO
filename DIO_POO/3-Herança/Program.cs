using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro("Ford", "Ka", "Prata");
            var aviao = new Aviao("Airbus", "A320", "Branco", 4);

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
