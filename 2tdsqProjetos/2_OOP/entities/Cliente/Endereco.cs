namespace _2_OOP.entities;

public class Endereco
{
    public string logradouro { get; set; }
    public string numero { get; set; }
    public string cidade { get; set; }
    public string estado { get; set; }
    public string cep { get; set; }

    public override string ToString() => 
        $"Logradouro: {logradouro}" +
        $",Numero: {numero}" +
        $",Cidade: {cidade}" +
        $",Estado: {estado}" +
        $",CEP: {cep}";
    
}