using System;

namespace ByteBank
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//ContaCorrente contaDaGabriela = new ContaCorrente();

			//contaDaGabriela.titular = "Gabriela";
			//contaDaGabriela.agencia = 863;
			//contaDaGabriela.numero = 863452;
			//contaDaGabriela.saldo = 100;

			//Console.WriteLine(contaDaGabriela.titular);
			//Console.WriteLine("Agência: " + contaDaGabriela.agencia);
			//Console.WriteLine("Número: " + contaDaGabriela.numero);
			//Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

			//contaDaGabriela.saldo += 200;

			//Console.WriteLine("Novo Saldo: " + contaDaGabriela.saldo);

			//Console.WriteLine("---------------------------------------");

			//ContaCorrente contaDaGabriela = new ContaCorrente();
			//contaDaGabriela.titular = "Gabriela";
			//contaDaGabriela.agencia = 863;
			//contaDaGabriela.numero = 863452;

			//ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
			//contaDaGabriela.titular = "Gabriela";
			//contaDaGabriela.agencia = 863;
			//contaDaGabriela.numero = 863452;

			//Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

			//Console.WriteLine("---------------------------------------");

			//ContaCorrente contaDoBruno = new ContaCorrente();
			////Console.WriteLine("antes do saque contadoBruno.saldo {0}", contaDoBruno.saldo);
			//contaDoBruno.Sacar(50);
			////Console.WriteLine("depois de sacar 50 contadoBruno.saldo {0}", contaDoBruno.saldo);

			//contaDoBruno.Depositar(500);

			////Console.WriteLine("depois de depositar 500 contadoBruno.saldo {0}", contaDoBruno.saldo);

			//ContaCorrente contaDaGabriela = new ContaCorrente();
			//contaDaGabriela.titular = "Gabriela";

			//Console.WriteLine("antes de transferir contaDaGabriela.saldo {0}", contaDaGabriela.saldo);
			//Console.WriteLine("antes de transferir contaDoBruno.saldo {0}", contaDoBruno.saldo);

			//contaDoBruno.Transferir(200, contaDaGabriela);

			//Console.WriteLine("depois de transferir contaDaGabriela.saldo {0}", contaDaGabriela.saldo);
			//Console.WriteLine("depois de transferir contaDoBruno.saldo {0}", contaDoBruno.saldo);

			//Console.WriteLine("---------------------------------------");

			////Cliente gabriela = new Cliente();
			////gabriela.nome = "Gabriela";
			////gabriela.profissao = "Desenvolvedora C#";
			////gabriela.cpf = "123.123.123-12";

			//ContaCorrente conta = new ContaCorrente();
			//conta.titular = new Cliente();
			//conta.titular.nome = "Gabriela";
			//conta.saldo = 500;
			//conta.agencia = 563;
			//conta.numero = 123123;

			////Console.WriteLine(gabriela.nome);
			////Console.WriteLine(conta.titular.nome);

			////gabriela.nome = "Gabriela Costa";

			////Console.WriteLine(gabriela.nome);
			//Console.WriteLine(conta.titular.nome);

			//Console.ReadLine();

			//Console.WriteLine("---------------------------------------");

			//ContaCorrente conta = new ContaCorrente();
			//Cliente cliente = new Cliente();

			//cliente.Nome = "Guilherme";
			//cliente.CPF = "002.929.818-12";
			//cliente.Profissao = "Desenvolvedor";

			//conta.Saldo = -10;
			//conta.Titular = cliente;

			////conta.saldo = -10;
			////Console.WriteLine(conta.saldo);

			//Console.WriteLine(conta.Titular.Nome);
			//Console.WriteLine(conta.Saldo);

			//Console.WriteLine("---------------------------------------");

			ContaCorrente conta = new ContaCorrente(867, 82827282);

			Console.WriteLine(conta.Agencia);
			Console.WriteLine(conta.Numero);

			ContaCorrente contaDaGabriela = new ContaCorrente(123, 2123123);

			Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

			Console.ReadLine();
		}
	}
}
