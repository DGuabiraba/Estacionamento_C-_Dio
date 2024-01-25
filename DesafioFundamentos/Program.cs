using System.Runtime.CompilerServices;
using DesafioFundamentos.Models;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;


// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
string valorInicial;
string horaInicial;


Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
      "Digite o preço inicial:");
      valorInicial = Console.ReadLine();


/*foi adicionado um laço, para se caso o usuario adicionar um valor vazio
ele ser obrigado a preencher */


    while(valorInicial == string.Empty)
    {
    Console.WriteLine("O valor inicial não pode ser vazio !\nDigite o preço inicial:  ");
    valorInicial = Console.ReadLine();

    }


Console.WriteLine("Agora digite o preço por hora:");
horaInicial = Console.ReadLine();



  while(horaInicial == string.Empty)
  {
    Console.WriteLine("O preço da hora não pode ser nulo!\nDigite o preço da hora:  ");
    horaInicial = Console.ReadLine();
  }



precoPorHora = Convert.ToDecimal(horaInicial);
precoInicial = Convert.ToDecimal(valorInicial);
// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
