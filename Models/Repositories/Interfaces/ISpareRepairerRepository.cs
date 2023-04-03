using BIRC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIRC.Models.Repositories.Interfaces
{
    interface ISpareRepairerRepository
    {
        Task<IList<SpareRepairer>> GetElements();
    }
}




