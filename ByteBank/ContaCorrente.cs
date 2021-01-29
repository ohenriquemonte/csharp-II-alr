using System;
namespace ByteBank
{
	public class ContaCorrente
	{

		public int Agencia { get; set; }
		public int Numero { get; set; }
		private double _saldo = 100;

		public Cliente Titular
		{
			//get
			//{
			//	return _titular;
			//}

			//set
			//{
			//	this._titular = value; // this não obrigatório
			//}

			get;
			set;
		}

		public static int TotalDeContasCriadas { get; private set; }

		public ContaCorrente(int agencia, int numero)
		{
			this.Agencia = agencia; // this não obrigatório
			Numero = numero; // this não obrigatório

			TotalDeContasCriadas++; // this não obrigatório
		}

		public double Saldo
		{
			get
			{
				return _saldo;
			}

			set
			{
				if (value < 0)
					return;

				this._saldo = value; // this não obrigatório
			}
		}


		public void Depositar(double valor)
		{
			this._saldo += valor; // this não obrigatório
		}

		//public double GetSaldo()
		//{
		//	return saldo;
		//}

		public bool Sacar(double valor)
		{
			if (this._saldo < valor) // this não obrigatório
			{
				Console.WriteLine("Saldo insuficiente");

				return false;
			}

			this._saldo -= valor;
			Console.WriteLine("Pode sacar, seu saldo agora é {0}", this._saldo); // this não obrigatório

			return true;
		}

		//public void SetSaldo(double saldo)
		//{
		//	if (saldo < 0)
		//		return;

		//	this.saldo = saldo; // this obrigatório
		//}

		public bool Transferir(double valor, ContaCorrente contaDestino)
		{
			if (this._saldo < valor) // this não obrigatório
			{
				return false;
			}

			contaDestino.Depositar(valor);
			this.Sacar(valor);

			return true;
		}
	}
}
