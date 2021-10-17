using System;

namespace ThreadConversa
{
    public class Texto: Mensagem
    {
        public new string Conteudo { get; set; }
        
        public Texto (string id, string conteudo, DateTime datahora, Identidade emissor) : base(id, conteudo, datahora, emissor)
        {
        }   
    }
}
