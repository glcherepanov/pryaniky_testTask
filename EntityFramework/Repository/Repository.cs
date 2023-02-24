using EntityFramework.Entity;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public IQueryable<TEntity> All { get; }

        private DbSet<TEntity> Table => _dBContext.Set<TEntity>();
        private readonly PryanikyDBContext _dBContext;

        public Repository(PryanikyDBContext dBContext)
        {
            _dBContext = dBContext;
            All = Table;
        }

        public TEntity FindById(int id)
        {
            return Table.Find(id);
        }

        public TEntity Create(TEntity entity)
        {
            Table.Add(entity);
            _dBContext.SaveChanges();

            return entity;
        }

        public TEntity Remove(int id)
        {
            var entity = Table.Find(id);

            if (entity != null)
            {
                Table.Remove(entity);
                _dBContext.SaveChanges();
            }

            return entity;
        }
    }
}
