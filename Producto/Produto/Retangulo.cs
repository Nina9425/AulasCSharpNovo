using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Retangulo
    {
        public double largura;
        public double altura;


        public double getCalcular()
        {
            return largura * altura;
        }
        public double perimetro()
        {
           
            return 2 * getCalcular();

        }
    }
}
