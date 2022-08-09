using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTriangulo
{
    internal class Triangulo
    {
        // Classes também são tipos
        public double A; // nome de atributo começa com letra maiúscula
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        
    }
}
