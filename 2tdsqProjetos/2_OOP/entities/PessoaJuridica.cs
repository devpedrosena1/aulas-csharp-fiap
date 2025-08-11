namespace _2_OOP.entities;

public class PessoaJuridica : Pessoa
{
    public string cnpj { get; set; }

    public override string ToString() => base.ToString() + "," + $"CNPJ: {cnpj}";
    
}