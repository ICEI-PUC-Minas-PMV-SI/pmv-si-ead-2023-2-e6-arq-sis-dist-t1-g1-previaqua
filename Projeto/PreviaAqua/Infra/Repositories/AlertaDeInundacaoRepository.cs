using Domain.Entidades;
using Domain.ValueObjects;
using Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class AlertaDeInundacaoRepository : IAlertaDeInundacaoRepository
    {
        private readonly ApplicationDbContext _context;
        protected readonly DbSet<AlertaDeInundacao> dbSet;

        public AlertaDeInundacaoRepository(ApplicationDbContext context)
        {
            _context = context;
            dbSet = _context.Set<AlertaDeInundacao>();
        }

        public async Task<IEnumerable<AlertaDeInundacao>> ObterAlertasPorLocalizacaoAsync(Localizacao localizacao)
        {
            return await dbSet
                .Where(x => x.Localizacao.Equals(localizacao))
                .ToListAsync();
        }

        public async Task<AlertaDeInundacao?> ObterAlertaPorIdAsync(Guid id)
        {
            return await dbSet.Where(x => x.Id == id).FirstOrDefaultAsync();
        }


        public async Task AdicionarAlertaAsync(AlertaDeInundacao alerta)
        {
            await dbSet.AddAsync(alerta);
        }

        public async Task<bool> AtualizarAlertaAsync(AlertaDeInundacao alerta)
        {
            var existingAlerta = await dbSet.FindAsync(alerta.Id); 
            if (existingAlerta == null)
                return false;

            dbSet.Update(alerta);
                return true;
        }

        public async Task<bool> DesativarAlertaAsync(Guid id)
        {
            var existingAlerta = await dbSet.FindAsync(id);

            if (existingAlerta != null && !existingAlerta.DesativarAlertaDeInundacao())
                return false;

            dbSet.Update(existingAlerta);
            return true;
        }

        public async Task<bool> AtivarAlertaAsync(Guid id)
        {
            var existingAlerta = await dbSet.FindAsync(id);

            if (existingAlerta != null && !existingAlerta.AtivarAlertaDeInundacao())
                return false;

            dbSet.Update(existingAlerta);
            return true;
        }
    }
}
