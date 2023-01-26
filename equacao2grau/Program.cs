using System;
using System.Numerics;
using Equacao;

namespace execucao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculo calculo = new Calculo();
            Console.Write("Digite o valor de A: ");
            calculo.valorA = int.Parse(Console.ReadLine()?? " ");
            Console.Write("Digite o valor de B: ");
            calculo.valorB = int.Parse(Console.ReadLine()?? " ");
            Console.Write("Digite o valor de C: ");
            calculo.valorC = int.Parse(Console.ReadLine()?? " ");
            calculo.executor();
        }
    }
}