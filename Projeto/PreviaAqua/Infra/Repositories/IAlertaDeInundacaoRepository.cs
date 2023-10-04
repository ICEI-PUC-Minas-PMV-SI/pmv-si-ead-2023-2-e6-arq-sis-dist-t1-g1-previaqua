using Domain.Entidades;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface IAlertaDeInundacaoRepository
    {

        public Task<IEnumerable<AlertaDeInundacao>> ObterAlertasPorLocalizacaoAsync(Localizacao localizacao);
        public Task<AlertaDeInundacao?> ObterAlertaPorIdAsync(Guid id);
        public Task AdicionarAlertaAsync(AlertaDeInundacao alerta);
        public Task<bool> AtualizarAlertaAsync(AlertaDeInundacao alerta);
        public Task<bool> DesativarAlertaAsync(Guid id);
        public Task<bool> AtivarAlertaAsync(Guid id);
        
    }
}
