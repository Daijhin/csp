using System;

namespace MeuProjeto
{
    public class Triangulo
    {
        public int lado_A
        {
            get{return lado_A;} set{lado_A = value;}
        }
        public int lado_B
        {
            get{return lado_B;} set{lado_B = value;}
        }
        public int lado_C
        {
            get{return lado_C;} set{lado_C = value;}
        }
        public void  verificarTriangulo()
        {
            if(lado_A < lado_B + lado_C || lado_B < lado_A + lado_C || lado_C < lado_A + lado_B)
            {
                 Console.WriteLine("É um triangulo");
            }
            else
            {
                 Console.WriteLine("Não é um triangulo");
            }
        }
        
    }
}