using EntityFramework.Entity;

namespace EntityFramework.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        public IQueryable<TEntity> All { get; }
        public TEntity FindById(int id);
        public TEntity Create(TEntity entity);
        public TEntity Remove(int id);
    }
}
