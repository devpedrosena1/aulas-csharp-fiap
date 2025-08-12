namespace _2_OOP.entities;

public class PessoaFisica : Pessoa
{
    public int idade { get; set; } 
    public string cpf { get; set; } = string.Empty;

    public override string ToString() => base.ToString() + "," + $" CPF: {cpf}, Idade: {idade}";
    
}