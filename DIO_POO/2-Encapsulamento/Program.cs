namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Veiculo("ford", "ka", "prata", "flex");
            var moto = new Veiculo();

            carro.ligar();
            carro.acelerar();
            carro.frear();
            carro.desligar();

            moto.ligar();
            moto.acelerar();
            moto.frear();
            moto.desligar();
        }
    }
}
