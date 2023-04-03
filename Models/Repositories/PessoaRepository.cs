using BIRC.Models.Entities;
using BIRC.Models.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BIRC.Models.Repositories
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(Contexto contexto) : base(contexto) 
        {

        }
        public async Task<IList<Pessoa>> GetElements()
        {
            return await DbSet.ToListAsync();
        }


    }
}
