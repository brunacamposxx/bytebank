using System;
using ByteBank.Titular;

namespace ByteBank
{
	// classe é um modelo. a partir dela criamos os objetos
	public class ContaCorrente
	{
		// campo - variaveis com valores default;
		public Cliente titular;
		public string conta;
		public int numero_agencia;
		public string nome_agencia;
		public double saldo;

		// método tipo bool, int, double, todos retornam valor
		public bool Sacar(double valor)
		{
			if (saldo < valor || valor < 0)
			{
				return false;
			}
			else
			{
				saldo = saldo - valor;
				return true;
			}
		}

		// declarar um método tipo void não retorna valor, apenas executa
		public void Depositar(double valor)
		{
			saldo = saldo + valor;
		}


		public bool Transferir(double valor, ContaCorrente destino)
		{
			if (saldo < valor)
			{
				return false;
			}
			if (saldo < 0)
			{
				return false;
			}
			else
			{
				saldo = saldo - valor;
				destino.saldo = destino.saldo + valor;
				return true;
			}
		}
	}
}

