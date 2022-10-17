namespace api_mcf.Repository
{
    public interface IBaseRepository<T>
    {
        T Get(int id);
        void Delete(int id);
        void Update(string code);
        void Create(T entity);
        void Read(T entity);
    }
}
