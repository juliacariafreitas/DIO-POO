using System.Collections.Generic;
using System.Linq;
using System;

namespace ThreadConversa
{
    public interface IThread
    {

        public void SinconizaThread();

        public IEnumerable<Mensagem> AdicionaMensagem (Mensagem mensagem);

        public IEnumerable<Mensagem> AdicionaMensagens (IEnumerable<Mensagem> mensagens);

        public string MostraThread();

        public void RemoveMensagem (string id);
    }
}
