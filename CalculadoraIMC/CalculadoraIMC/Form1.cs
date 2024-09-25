using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        IMCCalculadora calculadora = new IMCCalculadora();  // Instancia de la clase lógica


        CalculoIMC[] listado = new CalculoIMC[5];


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                double peso = double.Parse(txtPeso.Text);
                double altura = double.Parse(txtAltura.Text);

                // Llamada a la capa lógica para calcular el IMC
                double imc = calculadora.CalcularIMC(peso, altura);

                // Mostrar el IMC
                lblIMC.Text = "Su IMC es: " + imc;

                // Llamada a la capa lógica para obtener la categoría
                string categoria = calculadora.ObtenerCategoriaIMC(imc);
                lblCategoria.Text = "Categoría: " + categoria;

                //limpia listado cuando esta lleno
                if (listado[4] != null) listado = new CalculoIMC[5];
                //se limpia la lista
                lista.Text = "";
                // recorrer listado para guardar calculo
                for (int i = 0; i < listado.Length; i++)
                {
                    if (listado[i] == null)
                    {
                        listado[i] = new CalculoIMC(peso, altura, imc, categoria);
                            break;
                    }
                }
                //recorrer listado para mostrar calculo en el txtbox
                for (int i = 0; i < listado.Length; i++)
                {
                    if (listado[i] != null)
                    {
                        lista.Text += $"peso (kg):{listado[i].peso}\t\naltura(cm):{listado[i].altura}" +
                            $"\t\nimc:{listado[i].imc}\t\ncategoria:{listado[i].categoria}\t\n\t\n";
                    }
                }

            }

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIMC_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
