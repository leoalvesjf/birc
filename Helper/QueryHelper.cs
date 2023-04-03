using BIRC.Models;

using System.Linq;
using Microsoft.EntityFrameworkCore;
using BIRC.Models.Repositories;

namespace BIRC.Helper
{
    public class QueryHelper<T> where T : BaseModel
    {
        protected readonly DbSet<T> DbSet;
        protected readonly Contexto _context;

        public QueryHelper(Contexto context)
        {
            _context = context;
            DbSet = context.Set<T>();
        }

        public QueryHelper()
        {
        }

        public int GetMaxId()
        {
            int id = 0;
            try
            {
                id = DbSet.Select(p => p.Id).Max();
            }
            catch (System.Exception)
            {
            }

            return id + 1;

        }

        public string GetUserLogged()
        {
            var user = new System.Security.Principal.WindowsPrincipal(System.Security.Principal.WindowsIdentity.GetCurrent()).Identity.Name.Replace(@"ERICSSON\", "");
            return user;
        }

    }
}
