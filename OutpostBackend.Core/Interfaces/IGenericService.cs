namespace OutpostBackend.Core.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetListAsync();
    }
}
