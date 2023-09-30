using Domain.Abstractions;
using Domain.Entidades;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class PrevisaoMeteorologicaRepository : IPrevisaoMeteorologicaRepository
    {
        private List<PrevisaoMeteorologica> _previsoes; // Simulando uma fonte de dados

        public PrevisaoMeteorologicaRepository()
        {
            // Inicialização do repositório com dados fictícios (você substituirá isso pelo acesso real ao banco de dados)
            _previsoes = new List<PrevisaoMeteorologica>
            {
                new PrevisaoMeteorologica
                (
                    DateTime.Now.AddDays(1),
                    25.5,
                    60.0,
                    12,
                    new Localizacao("Cidade", 12.1111, -77.7722)
                ),
                new PrevisaoMeteorologica
                (
                    DateTime.Now.AddDays(2),
                    27.0,
                    55.5,
                    10,
                    new Localizacao("Cidade", 11.1111, -77.7777)
                )
           
            };
        }


        public List<PrevisaoMeteorologica> ObterTodasPrevisoes()
        {
            return _previsoes;
        }

        public PrevisaoMeteorologica? ObterPrevisaoPorId(Guid id)
        {
            return _previsoes.FirstOrDefault(p => p.Id == id);
        }

        public void AtualizarPrevisao(PrevisaoMeteorologica previsao)
        {
           
            var previsaoExistente = _previsoes.FirstOrDefault(p => p.Id == previsao.Id);
            if (previsaoExistente != null)
            {
                previsaoExistente.DataHora = previsao.DataHora;
                previsaoExistente.Temperatura = previsao.Temperatura;
                previsaoExistente.Umidade = previsao.Umidade;
            }
        }

        public void DesativarPrevisao(Guid id)
        {
            var previsaoExistente = _previsoes.FirstOrDefault(p => p.Id == id);
            if (previsaoExistente != null)
            {
               
            }
        }
    }
}
