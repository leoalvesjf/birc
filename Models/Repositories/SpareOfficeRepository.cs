using BIRC.Models.Entities;
using BIRC.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BIRC.Models.Repositories
{
    public class SpareOfficeRepository : BaseRepository<SpareOffice>, ISpareOfficeRepository
    {
        public SpareOfficeRepository(Contexto contexto) : base(contexto)
        {

        }

        public async Task<IList<SpareOffice>> GetElements()
        {
            return await DbSet.ToListAsync();
        }
    }
}
