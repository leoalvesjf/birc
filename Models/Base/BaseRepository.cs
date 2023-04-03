using Microsoft.EntityFrameworkCore;


namespace BIRC.Models.Repositories
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        protected readonly Contexto context;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(Contexto wamContext)
        {
            context = wamContext;
            DbSet = wamContext.Set<T>();
        }
    }
}
