namespace _2_OOP.Repositories;

public interface IRepository<T>
{
    List<T> Entities { get; }
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
    T? GetBydId(int id);
    IEnumerable<T> GetAll();
}