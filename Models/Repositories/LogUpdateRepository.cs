using BIRC.Models.Entities;
using BIRC.Models.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BIRC.Models.Repositories
{
    public class LogUpdateRepository : BaseRepository<LogUpdate>, ILogUpdateRepository
    {
        public LogUpdateRepository(Contexto Context) : base(Context)
        {
        }

        public async Task<IList<LogUpdate>> GetUpdates()
        {
            return await DbSet.ToListAsync();
        }
    }
}
