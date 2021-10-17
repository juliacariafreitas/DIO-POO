using System.Runtime.Serialization;
using System;

namespace ThreadConversa
{
    public class Imagem: Mensagem
    {
        [DataMember(Name = "conteudo")]
        public new byte[] Conteudo { get; set; }
        
        public Imagem (byte[] conteudo) : base(conteudo)
        {

        }
        public Imagem (string id, byte[] conteudo, DateTime datahora, Identidade emissor) : base(id, conteudo, datahora, emissor)
        {
        }  
    }
}
