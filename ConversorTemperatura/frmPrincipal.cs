using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if (rbCelsius1.Checked == true)
            {
                if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = (valor + 273) + "K";
                }

                else
                    if (rbFahrenheit2.Checked == true)
                    {
                         txtResultado.Text = (valor * 1.8 + 32) + "°F";
                    }

                else
                {
                    txtResultado.Text = valor + "°C";
                }
                
                
            }

            else
                if (rbKelvin1.Checked == true)
                {
                    if (rbCelsius2.Checked == true)
                    {
                        txtResultado.Text = (valor - 273) + "°C";
                    }

                    else
                        if (rbFahrenheit2.Checked == true)
                        {
                            txtResultado.Text = (valor * 1.8 - 459.67) + "°F";
                        }

                    else
                    {
                        txtResultado.Text = valor + "K";
                    }

                }

            else
                if (rbFahrenheit1.Checked == true)//verifiva se a opção Fahrenheit do GroupBox Entrada está selecionada
                {
                    //verifica qual opção está selecionada no GruopBox Saída e realiza a conversão
                    //e atribui o resultado ao txtResulatado

                    if (rbCelsius2.Checked == true)
                    {
                         txtResultado.Text = ((valor - 32) / 1.8) + "°C";
                    }

                    else
                        if (rbKelvin2.Checked == true)
                        {
                            txtResultado.Text = ((valor + 459.67) / 1.8) + "K"; 
                        }
                    else
                    {
                        txtResultado.Text = valor + "°F";
                    }
                }

            else //no caso de todas as verificações retornarem falso
            {
                txtResultado.Text = valor.ToString();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtResultado.Text = "";

            foreach (Control Componente in gbEntrada.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }

            foreach (Control Componente in gbSaida.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }
        }
    }
}
