using System.Globalization;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace DesafioFundamentos.Models


{
    
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        /*foi adicionado a coleção Dictionary para evitar a repetição de placas 
        no sistema */
        private Dictionary<string,string> veiculos = new Dictionary<string,string>();
       
        

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }


        public void AdicionarVeiculo() //PRONTO
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            //implementação da data, para controle da hora de entrada é saida
            DateTime data = DateTime.Now;
            string placa = Console.ReadLine().ToUpper();
            /*foi gerado em uma forma condição para que o usuario n 
            cadastre valores vazios */   
         if(!string.IsNullOrEmpty(placa))
         {
            if (!veiculos.ContainsKey(placa))
             {
             veiculos.Add(placa,"veículo estacionado!");

             }
             else {
             Console.WriteLine("Placa já cadastrada!");
            }
      
         } 
        }

        public void RemoverVeiculo() //PRONTO
        {

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();
          

            // Verifica se o veículo existe, para a coleção Dictionary
            if (veiculos.Any(veiculos => veiculos.Key == placa))
            {

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt16(Console.ReadLine());
                DateTime data = DateTime.Now;
                // conversor de moeda
                CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
                
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);
                
                
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal.ToString("c", CultureInfo.CreateSpecificCulture("pt-BR"))} \nO veículo entrou: {data} e saiu: {data.AddHours(horas)}");
            }
              else 
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item + "\n");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}