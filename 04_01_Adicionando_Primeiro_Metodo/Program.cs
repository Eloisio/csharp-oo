using System;
using Contas;

namespace _04_01_Adicionando_Primeiro_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta(); 
            
            conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 100;

            conta.ExibirExtrato();
        }
    }
}
