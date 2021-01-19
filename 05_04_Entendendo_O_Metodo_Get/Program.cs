using System;
using RH;

namespace _05_04_Entendendo_O_Metodo_Get
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Joel", "000.000.000-00");
            Console.WriteLine(funcionario.CPF);
        }
    }
}
