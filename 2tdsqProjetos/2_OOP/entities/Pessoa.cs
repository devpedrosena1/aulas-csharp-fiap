namespace _2_OOP.entities;

// a declaração de uma classe é o padrão {acesso} class {NomeDaClasse}
public class Pessoa
{

    public string nome { get; set; }
    public string email { get; set; }
    public Endereco endereco { get; set; }

    // ctor -> atalho para escrever construtor vazio
    public Pessoa()
    {
        
    }

    // ctorp -> atalho para escrever construtor cheio
    public Pessoa(string nome, string email)
    {
        this.nome = nome;
        this.email = email;
    }

    public string ExibirDetalhes() => $"Nome: {nome}, Email: {email}";
    public override string ToString() => $"Nome: {nome}, Email: {email}, Endereco: {endereco}";
  
    

}