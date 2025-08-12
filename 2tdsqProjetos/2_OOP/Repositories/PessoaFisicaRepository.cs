using _2_OOP.entities;

namespace _2_OOP.Repositories;

public class PessoaFisicaRepository : IRepository<PessoaFisica>
{
    public List<PessoaFisica> Entities { get; init; }  = [];

    public void Add(PessoaFisica entity) => Entities.Add(entity);
    
    // TODO: Implementar o método Update
    public void Update(PessoaFisica entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id) => Entities.RemoveAll(e => e.Id == id);

    public PessoaFisica? GetBydId(int id) => Entities.FirstOrDefault(e => e.Id == id);

    public IEnumerable<PessoaFisica> GetAll() => Entities;
}