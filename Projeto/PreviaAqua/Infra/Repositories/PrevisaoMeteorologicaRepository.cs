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
                    new Guid(),
                    DateTime.Now.AddDays(1),
                    new Localizacao("Cidade", 12.1111, -77.7722,"Belo Horizonte", "Minas Gerais", "Municipio", "Bairro"),
                    new DadosClimaticos(1,1,1,1),
                    PeriodoPrevisao.Criar(DateTime.Now, DateTime.Now.AddDays(2))
                ),
                new PrevisaoMeteorologica
                (
                    new Guid(),
                     DateTime.Now.AddDays(1),
                    new Localizacao("Teste", 12.1111, -77.7722,"Belo Horizonte 1", "Minas Gerais 1", "Municipio 1", "Bairro2"),
                    new DadosClimaticos(12,21,12,1),
                    PeriodoPrevisao.Criar(DateTime.Now, DateTime.Now.AddDays(2))
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
