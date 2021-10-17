using System.Runtime.Serialization;
using System;

namespace ThreadConversa
{
    public class Identidade
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        public Identidade(string nome)
        {
            this.Nome = nome;
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
