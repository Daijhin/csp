using System;
using MeuProjeto;

namespace Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.lado_A = 10;
            triangulo.lado_B = 10;
            triangulo.lado_C = 10;
            triangulo.verificarTriangulo();
        }
    }
}