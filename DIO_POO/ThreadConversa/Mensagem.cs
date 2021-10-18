using System;

namespace ThreadConversa
{
    public abstract class Mensagem
    {
        public virtual Object Conteudo { get; set; }
        
        public DateTime Datahora { get; private set; }

        public Identidade Emissor { get; private set; }

        public string Id { get; private set; }

        public Mensagem(Object conteudo)
        {
            Console.WriteLine(conteudo);
            this.Id = Guid.NewGuid().ToString();
            this.Conteudo = conteudo;
            this.Datahora = DateTime.Now;
        }

        public Mensagem(string id, Object conteudo, DateTime datahora, Identidade emissor)
        {
            this.Id = id;
            this.Conteudo = conteudo;
            this.Datahora = datahora;
            this.Emissor = emissor;
        }
    }
}
