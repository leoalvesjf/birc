using BIRC.Models.Entities;
using BIRC.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BIRC.Models.Repositories
{
    public class ChemicalControlRepository : BaseRepository<SpareChemical>, IChemicalControlRepository
    {
        public ChemicalControlRepository(Contexto contexto) : base(contexto)
        {


        }

        public async Task<IList<SpareChemical>> GetElements()
        {
            return await DbSet.ToListAsync();
        }
    }
}
