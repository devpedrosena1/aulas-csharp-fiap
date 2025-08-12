using _2_OOP.entities.Produto;

namespace _2_OOP.Repositories;

public class ProdutoRepository : IRepository<Produto>
{
    public List<Produto> Entities { get; init; } = [];
    
    public void Add(Produto entity) => Entities.Add(entity);

    public void Update(Produto entity)
    {
        var oldEntity = Entities.FirstOrDefault(e => e.Id == entity.Id);
        if (oldEntity != null)
            return;
        
        oldEntity.Nome = entity.Nome;
        oldEntity.Preco = entity.Preco;
        
    }

    public void Delete(int id) => Entities.RemoveAll(e => e.Id == id);

    public Produto? GetBydId(int id) => Entities.FirstOrDefault(e => e.Id == id);

    public IEnumerable<Produto> GetAll() => Entities;
}