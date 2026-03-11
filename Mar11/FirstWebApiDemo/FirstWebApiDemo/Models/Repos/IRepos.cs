namespace FirstWebApiDemo.Models.Repos
{
    public interface IRepos<T>
    {
        T Get(int id);
        ICollection<T> GetAll();
        bool Add(T obj);
        bool Update(int id, T obj);
        bool Delete(int id);
    }
}
