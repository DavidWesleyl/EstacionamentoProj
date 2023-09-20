using System;
using System.ComponentModel.Design;

namespace projetoEstacionamento
{
	internal class Estacionamento // Classe estacionamento
	{
		public double PrecoInicial { get; set; }
		public double PrecoPorHora { get; set; }

		public List<string> Veiculos = new List<string>(); // Lista de veículos onde serão armazenados diversos valores.


		public Estacionamento(double precoInicial, double precoporHora) // Construtor para passarmos os valores e mostrar o preço
		{
			PrecoInicial = precoInicial;
			PrecoPorHora = precoporHora;

		}



		public void adicionarVeiculo() // Método adicionar veículos
		{
			Console.WriteLine(">> Opção 1 [Cadastrar veículo]");
			Console.WriteLine();

			Console.Write("Digite a Placa do veículo para estacionar: ");
			string placaVeiculo = Console.ReadLine();
			Veiculos.Add(placaVeiculo);

		}

		public void removerVeiculo() // Método remover veículos e irá perguntar a quantidade de horas no estacionamento para calcular o valor total.
		{


			Console.WriteLine(">> Opção 2 [Remover veículo]");
			Console.WriteLine();

			Console.Write("Digite a placa do veiculo para remover: ");
			string placaVeiculo = Console.ReadLine();



			if (Veiculos.Any()) // Verificar se o veículo existe, se existir: 
			{
				Console.Write("Digite a quantidade de horas que ele permaneceu estacionado: ");

				int horasEstacionado = int.Parse(Console.ReadLine());

				double total = (PrecoPorHora * horasEstacionado + PrecoInicial);

				Veiculos.Remove(placaVeiculo);

				Console.WriteLine($"O Veículo {placaVeiculo} foi removido e o total foi R$: {total}");

			}
			else
			{
				Console.WriteLine("O veículo informado não está cadastrado, verifique novamente.");

			}
			
		}


		public void listarVeiculo() // Método listar veiculos, irá mostrar os veiculos cadastrados
		{
			Console.WriteLine("Veiculos");

			if (Veiculos.Any()) // Se existir veículos, mostre:
			{
				foreach (var veiculo in Veiculos)
				{

					Console.WriteLine($"Placa {veiculo}");
				}

			}

			else
			{
				Console.WriteLine("Não há veículos estacionados. ");
			}






		}


	}
}
