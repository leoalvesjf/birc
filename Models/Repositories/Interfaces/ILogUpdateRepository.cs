using BIRC.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BIRC.Models.Repositories.Interfaces
{
    interface ILogUpdateRepository
    {
        Task<IList<LogUpdate>> GetUpdates();
    }
}
