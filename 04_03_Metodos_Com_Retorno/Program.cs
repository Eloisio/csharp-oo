using System;
using Contas;

namespace _04_03_Metodos_Com_Retorno
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta(); 
            
            conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 100;

            Console.WriteLine(conta.ExibirExtrato());
            conta.Depositar(50);
            Console.WriteLine(conta.ExibirExtrato());
            conta.Sacar(30);
            Console.WriteLine(conta.ExibirExtrato());
        }
    }
}
