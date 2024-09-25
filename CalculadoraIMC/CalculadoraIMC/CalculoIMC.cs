using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    public class CalculoIMC
    {
        public double peso { get; set; }
        public double altura { get; set; }
        public double imc { get; set; }
        public string categoria { get; set; }

        public CalculoIMC(double peso, double altura, double imc, string categoria)
        {
            this.peso = peso;
            this.altura = altura;
            this.imc = imc;
            this.categoria = categoria;

        }
    }
}
