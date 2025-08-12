using _2_OOP.entities;

namespace _2_OOP.Repositories;

public class PessoaJuridicaRepository : IRepository<PessoaJuridica>
{
    public List<PessoaJuridica> Entities { get; } = [];

    public void Add(PessoaJuridica entity)
    {
        throw new NotImplementedException();
    }

    public void Update(PessoaJuridica entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public PessoaJuridica GetBydId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PessoaJuridica> GetAll()
    {
        throw new NotImplementedException();
    }
}