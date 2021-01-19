using System;
using Contas;

namespace _03_03_Adicionando_Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta(); 
            
            conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 100;

            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.DataAbertura);
            Console.WriteLine(conta.Saldo);
        }
    }
}
