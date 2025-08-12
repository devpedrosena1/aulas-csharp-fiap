// See https://aka.ms/new-console-template for more information

using _2_OOP.entities;
using _2_OOP.entities.Produto;
using _2_OOP.Repositories;

Console.WriteLine("Hello, World!");

// // primeira forma de instanciar
// var novaPessoa = new Pessoa();
// novaPessoa.nome = "João";
// novaPessoa.email = "joao@gmail.com";
//
// // segunda forma de instanciar
// var pessoa = new PessoaFisica()
// {
//     nome = "Pedro",
//     email = "pedro@gmail.com",
//     cpf = "123.456.789-0",
//     idade = 19
// };
//
// Console.WriteLine(pessoa);
//
// var novaEmpresa = new PessoaJuridica()
// {
//     nome = "FIAP",
//     cnpj = "123.456.789-0",
//     email = "fiap@gmail.com",
//     endereco = new Endereco()
//     {
//         logradouro = "Avenida Paulista 1000A"
//     }
// };
//
// Console.WriteLine(novaEmpresa);

var pessoaFisicaRepo = new PessoaFisicaRepository();
pessoaFisicaRepo.Add(new PessoaFisica(){Id = 1, nome = "João", cpf = "123.456.678-9", idade = 30});
pessoaFisicaRepo.Add(new PessoaFisica(){Id = 2, nome = "Maria", cpf = "123.456.678-9", idade = 25});
pessoaFisicaRepo.Add(new PessoaFisica(){Id = 3, nome = "Pedro", cpf = "123.456.678-9", idade = 40});

foreach (var pessoa in pessoaFisicaRepo.GetAll())
    Console.WriteLine(pessoa);

pessoaFisicaRepo.Delete(2);
Console.WriteLine("Peassoa deletada com sucesso!");

foreach (var pessoa in pessoaFisicaRepo.GetAll())
    Console.WriteLine(pessoa);

Console.WriteLine(pessoaFisicaRepo.GetBydId(2));

var produtoRepository = new ProdutoRepository();
produtoRepository.Add(new Produto(){Id = 1, Nome = "Iphone 16", Preco = 10000});

foreach (var produto in produtoRepository.Entities)
    Console.WriteLine(produto);

