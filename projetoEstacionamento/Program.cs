using System;
using System.Globalization; // irá mudar o formato de dinheiro de vírgula, para ponto. ex: 2,35 => 2.35
using System.Linq.Expressions;
using projetoEstacionamento;
internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("SEJA BEM VINDO AO SISTEMA DE ESTACIONAMENTO. ");
		Console.WriteLine();

		Console.Write("Digite o preço inicial R$: ");
		double precoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

		Console.Write("Digite o preço por hora R$: ");
		double precoPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		Estacionamento sistemaEstacionamento = new Estacionamento(precoInicial, precoPorHora);


		//string opcao =" ";
		bool exibirMenu = true;



		while (exibirMenu) // Enqunto a opção Exibir menu for verdadeira:
		{

			Console.Clear();

			Console.WriteLine("M E N U");
			Console.WriteLine();
			Console.WriteLine("Digite a opção desejada:");
			Console.WriteLine();
			Console.WriteLine("=-=-=-=-=-=-=-=-==-=-=-=");
			Console.WriteLine("Cadastrar veículo - 1");
			Console.WriteLine("Remover veiculo - 2");
			Console.WriteLine("Listar véiculos - 3");
			Console.WriteLine("Encerrar - 4 ");

			Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=");



			switch (Console.ReadLine())
			{
				case "1":
					sistemaEstacionamento.adicionarVeiculo();
					break;

				case "2":
					sistemaEstacionamento.removerVeiculo();
					break;

				case "3":
					sistemaEstacionamento.listarVeiculo();
					break;

				case "4":
					exibirMenu = false; // Quando for false, saia do programa.
					break;

				default:
					Console.WriteLine("Opção inválida!");
					break;


			}
			Console.WriteLine();

			Console.WriteLine("Pressione uma tecla para prosseguir");
			Console.ReadLine();

		}

		Console.WriteLine("O programa encerrou! ");
	}















}
