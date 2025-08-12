namespace _2_OOP.entities.Produto;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    
    public override string ToString() => $"ID: {Id}, Nome: {Nome}, Preco: {Preco}";
}