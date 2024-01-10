
using System;
namespace CursoC_.models
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;
         
         public double Area()
         {
           Double P = (A + B + C) / 2.0;
           return Math.Sqrt(P *(P - A)* (P - B) * (P - C));
         }
        
    }
}