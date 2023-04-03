using BIRC.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BIRC.Models.Repositories.Interfaces
{
    interface IPessoaRepository
    {
        Task<IList<Pessoa>> GetElements();
    }                                                                                                                               
}
