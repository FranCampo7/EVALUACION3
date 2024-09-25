using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    public class IMCCalculadora
    {
        public double CalcularIMC(double peso, double altura)
        {
            double alturaM = altura / 100;

            return peso / (alturaM * alturaM);
        }

        public string ObtenerCategoriaIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Bajo peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Obesidad";
            }

        }
    }
}
