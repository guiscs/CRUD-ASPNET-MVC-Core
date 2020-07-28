using Catalogo.Business.Notificacoes;
using System.Collections.Generic;

namespace Catalogo.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacao();
        void Handle(Notificacao notificacao);
    }
}
