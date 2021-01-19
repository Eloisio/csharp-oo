using System;
using RH;

namespace _05_03_Aplicando_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Joel", "000.000.000-00");
            Console.WriteLine(funcionario.GetCPF());
            funcionario.SetCPF("");
            Console.WriteLine(funcionario.GetCPF());
        }
    }
}
