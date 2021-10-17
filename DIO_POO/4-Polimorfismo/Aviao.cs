using System;

namespace Polimorfismo
{
    class Aviao : Veiculo
    {
        public Aviao(string marca, string modelo, string cor, int numero_turbinas)
        : base(marca, modelo, cor)
        {
        }
    }
}
