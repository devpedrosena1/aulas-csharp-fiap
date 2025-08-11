namespace _2_OOP.entities;

// a declaração de uma classe é o padrão {acesso} class {NomeDaClasse}
public class Pessoa
{

    public string nome { get; set; }
    public int idade { get; set; }
    public string email { get; set; }

    // ctor -> atalho para escrever construtor vazio
    public Pessoa()
    {
        
    }

    // ctorp -> atalho para escrever construtor cheio
    public Pessoa(string nome, int idade, string email)
    {
        this.nome = nome;
        this.idade = idade;
        this.email = email;
    }

    public string ExibirDetalhes() => $"Nome: {nome}, idade: {idade}, Email: {email}";
    

}