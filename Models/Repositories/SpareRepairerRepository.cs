using BIRC.Models.Entities;
using BIRC.Models.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIRC.Models.Repositories
{
    public class SpareRepairerRepository : BaseRepository<SpareRepairer> , ISpareRepairerRepository
    {
        public SpareRepairerRepository(Contexto contexto) : base(contexto)
        {


        }

        public async Task<IList<SpareRepairer>> GetElements()
        {
            return await DbSet.ToListAsync();
    }
    }
}
