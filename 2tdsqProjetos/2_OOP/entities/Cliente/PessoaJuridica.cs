namespace _2_OOP.entities;

public class PessoaJuridica : Pessoa
{
    public string cnpj { get; set; } = string.Empty; // poderia usar o required também

    public override string ToString() => base.ToString() + "," + $"CNPJ: {cnpj}";
    
}