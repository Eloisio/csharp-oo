using System;
using RH;

namespace _05_05_Entendendo_O_Metodo_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Joel", "000.000.000-00");
            funcionario.CPF = "";
            Console.WriteLine(funcionario.CPF);
        }
    }
}
