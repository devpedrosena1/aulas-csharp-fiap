// See https://aka.ms/new-console-template for more information

using _2_OOP.entities;

Console.WriteLine("Hello, World!");

// primeira forma de instanciar
var novaPessoa = new Pessoa();
novaPessoa.nome = "João";
novaPessoa.email = "joao@gmail.com";

// segunda forma de instanciar
var pessoa = new PessoaFisica()
{
    nome = "Pedro",
    email = "pedro@gmail.com",
    cpf = "123.456.789-0",
    idade = 19
};

Console.WriteLine(pessoa);

var novaEmpresa = new PessoaJuridica()
{
    nome = "FIAP",
    cnpj = "123.456.789-0",
    email = "fiap@gmail.com"
};

Console.WriteLine(novaEmpresa);
