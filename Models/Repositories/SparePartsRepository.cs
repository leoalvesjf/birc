using BIRC.Models.Entities;
using BIRC.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BIRC.Models.Repositories
{
    public class SparePartsRepository : BaseRepository<SpareParts>, ISparePartsRepository
    {
        public SparePartsRepository(Contexto contexto) : base(contexto)
        {

        }         
                  
        public async Task<IList<SpareParts>> GetElements()
        {
            return await DbSet.ToListAsync();
        }
    }
   

}


