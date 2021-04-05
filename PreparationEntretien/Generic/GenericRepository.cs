using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace PreparationEntretien.Generic
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public Task<TEntity> GetById(int id);
    }
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>  where TEntity : class
    {
        public MyContext Context { get; set; }

        public GenericRepository()
        {
            Context.Set<TEntity>(nameof(TEntity));
        }
        public async Task<TEntity> GetById(int id)
        {
           return (TEntity) await Context.FindAsync(typeof(TEntity), id).ConfigureAwait(false);
        }
    }

    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
    }
}
