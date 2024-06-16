// See https://aka.ms/new-console-template for more information
using Comex;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");

// Atividade 1

var produto = new Produto();
produto.Nome = "Notebook";
produto.Descricao = "Notebook novo de alta perfomance";
produto.PrecoUnitario = 500.50;
produto.Quantidade = 10;

Console.WriteLine(produto.Nome);
Console.WriteLine(produto.Descricao);
Console.WriteLine(produto.PrecoUnitario);
Console.WriteLine(produto.Quantidade);

//Atividade 2

var endereco = new Endereco();
endereco.Rua = "Av.Paulista";

var cliente = new Cliente();
cliente.Nome = "William";
cliente.Endereco = endereco;

Console.WriteLine(cliente.Nome);
Console.WriteLine(cliente.Endereco.Rua);


// Atividade 3

var produto = new Produto("Notebook");
Console.WriteLine(produto.Nome);

// Atividade 4


void ExibirLogo()
{
    Console.WriteLine(@"logo que pede na atividade");

    Console.WriteLine("\nBem vindo ao Comex");
}


void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 Criar Produto");
    Console.WriteLine("\nDigite 2 Listar Produtos");
    Console.WriteLine("\nDigite -1 para sair");

    Console.WriteLine("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch(opcaoEscolhidaNumerica)
    {
        case 1 :
            CriarProduto();
            break;
        case 2 :
            ListarProdutos();
            break;  
        case -1 :
            Console.WriteLine("Saindo");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

ExibirOpcoesDoMenu();




// Atividade4

void CriarProduto()
{
    Console.Clear();
    Console.WriteLine("Registro de Produtos");

    Console.WriteLine("Digite o nome do produto: ");
    string nomeDoProduto = Console.ReadLine();
    var produto = new Produto(nomeDoProduto);

    Console.WriteLine("Digite a descrição do Produto: ");
    string descricao = Console.ReadLine();
    produto.Descricao = descricao;

    Console.WriteLine("Digite o preço do Produto: ");
    string preco = Console.ReadLine();
    produto.PrecoUnitario = double.Parse(preco);

    ListaProdutos.Add(produto);
    Console.WriteLine($"O Produto {produto.Nome} foi registrado com Sucesso");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();




}

void ListaProdutos()
{
    Console.Clear();
    Console.WriteLine("Listagem de Produtos");


    foreach (var produto in ListaProdutos)
        Console.WriteLine($"Produto:{produto.Nome}");
}
    














