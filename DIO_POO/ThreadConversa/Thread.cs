using System.Collections.Generic;
using System.Linq;
using System;

namespace ThreadConversa
{
    public class Thread
    {
        public List<Mensagem> Mensagens { get; private set; }

        public int Tamanho { get; private set; }

        public Identidade Origem { get; private set; }

        public Identidade Destino { get; private set; }

        public Thread ()
        {
            Mensagens = new List<Mensagem>();
        }

        public void SinconizaThread() 
        {
            Console.WriteLine("Sincronizando");
        }

        public IEnumerable<Mensagem> AdicionaMensagem (Mensagem mensagem) => AdicionaMensagemNaThread (mensagem);

        public IEnumerable<Mensagem> AdicionaMensagens (IEnumerable<Mensagem> mensagens) {
            foreach (var mensagem in mensagens) 
            {
                AdicionaMensagemNaThread(mensagem);
            }

            return Mensagens;
        }

        public string MostraThread()
        {
            var thread = "";
            foreach (var mensagem in Mensagens) 
            {
                thread = thread + $"{mensagem.Emissor.Nome}: {mensagem.Conteudo}\n";
            }

            return thread;
        }

        private List<Mensagem> AdicionaMensagemNaThread (Mensagem mensagem)
        {
            Console.WriteLine("Adicionando mensagem na thread");
            Mensagens.Add(mensagem);
            return Mensagens;
        }

        public void RemoveMensagem (string id) => RemoveMensagemDaThread(id);

        private void RemoveMensagemDaThread (string id)
        {
            Console.WriteLine("Removendo mensagem da thread");
            Mensagens = Mensagens.Where(msg => msg.Id != id).ToList();
        }
    }
}
