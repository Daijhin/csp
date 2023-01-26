using System;
using System.Numerics;
namespace Equacao
{
    /// startando os coeficientes
    public class Calculo
    {
        public int valorA;
        public int valorB;
        public int valorC;
        public double delta;
        public bool aIgual0;
        public bool deltanegativo;
        public double x1;
        public double x2;
        public void executor()
        {
            verificarAigual0();
            CalcularDelta();
            verificarDNegativo();
        }
        //verificando se A é igual a 0
        public void verificarAigual0()
        {
            if(valorA == 0)
            {
                aIgual0 = true;
                resultado();
            }
            else
            {
                aIgual0 = false;
            }
        }
        //calculando delta
        public void CalcularDelta()
        {
            delta = Math.Pow(valorB, 2) - 4 * valorA * valorC;
        }
        //verificando se delta e negativo
        public void verificarDNegativo()
        {
            if(delta < 0)
            {
                deltanegativo = true;
                Console.WriteLine("\nDelta é negativo, não existe raiz real");
            }
            else
            {
                deltanegativo = false;
                calcularx1();
                calcularx2();
                imprimir();
            }
        }
        //calculando x
        public void calcularx1()
        {
            x1 = (-valorB + Math.Sqrt(delta)) / (2 * valorA);
        }
        public void calcularx2()
        {
            x2 = (-valorB - Math.Sqrt(delta)) / (2 * valorA);
        }
        //imprimindo os resultados
        public void imprimir()
        {
            Console.WriteLine("O valor de x1 é: " + x1);
            Console.WriteLine("O valor de x2 é: " + x2);
        }
        //tratamento do igual a 0
        public void resultado()
        {
            if(aIgual0 == true)
            {
                Console.Write("A equação não é de segundo grau,\nDigite um novo valor de a: ");
                valorA = int.Parse(Console.ReadLine()?? " ");
                verificarAigual0();
                CalcularDelta();
                calcularx1();
                calcularx2();
                imprimir();
            }
        }
    }
}