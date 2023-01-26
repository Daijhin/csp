using System;

namespace MeuProjeto
{
    public class Triangulo
    {
        public int lado_A;
        public int lado_B;
        public int lado_C;
        public bool ehTriangulo;
        public void  verificarTriangulo()
        {
            Console.WriteLine("Verificando se é um triangulo...");

            if(lado_A < lado_B + lado_C || lado_B < lado_A + lado_C || lado_C < lado_A + lado_B)
            {
                 Console.WriteLine("É um triangulo!");
                 ehTriangulo = true;
            }
            else
            {
                 Console.WriteLine("Não é um triangulo");
                 ehTriangulo = false;
            }
        }
        public void verificarTipoTriangulo()
        {
            if(ehTriangulo == true)
            {
                Console.WriteLine("\n Verificando o tipo de triandulo...");
                if(lado_A != lado_B && lado_A != lado_C && lado_B != lado_C)
                {
                    Console.WriteLine("É um triangulo escaleno");
                }
                else if(lado_A == lado_B && lado_A == lado_C && lado_B == lado_C)
                {
                    Console.WriteLine("É um triangulo equilatero");
                }
                else if(lado_A == lado_B || lado_A == lado_C || lado_B == lado_C)
                {
                    Console.WriteLine("É um triangulo isosceles");
                }
            }
        }
        
    }
}