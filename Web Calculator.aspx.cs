using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalculator_repaso_02_11
{
    public partial class Web_Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void CheckBox()
        {
            lresultado.Text = string.Empty;
            ClsCheckbox operacion = new ClsCheckbox(float.Parse(Tvalor1.Text), float.Parse(Tvalor2.Text));
        }
        public static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            else
                return n*Factorial(n-1);
        }
        private void Bcalcular_Click(object sender, EventArgs e)
        {
            Tvalor1.Text = Operaciones.valor1.ToString();
            Tvalor2.Text = Operaciones.valor2.ToString();

            double Numero1 = double.Parse(Tvalor1.Text);
            double Numero2 = double.Parse(Tvalor2.Text);
            double Resultado = 0;


            if (rsuma.Checked)
            {
                Resultado = Numero1 + Numero2;
            }
            else if (rresta.Checked)
            {
                Resultado = Numero1 - Numero2;
            }
            else if (rmulti.Checked)
            {
                Resultado = Numero1 * Numero2;
            }
            else if (rdivision.Checked)
            {
                Resultado = Numero1 / Numero2;
            }
            else if (RaizCu.Checked)
            {
                Resultado = Math.Sqrt(Numero1);
            }
            else if (Fibon.Checked)
            {
                Resultado = Fibonacci((int)Numero1);
            }
            else if (Facto.Checked)
            {
                Resultado = Factorial((int)Numero1);
            }
            else if (Pot2.Checked)
            {
                Resultado = Math.Pow(Numero1, 2);
            }
            else if (Pot3.Checked)
            {
                Resultado = Math.Pow(Numero1, 3);
            }
            lresultado.Text = Resultado.ToString();
        }
        protected void Tvalor1_TextChanged(object sender, EventArgs e)
        {}
        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {}
        protected void b1_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "1";
        }
        protected void b2_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "2";
        }
        protected void b3_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "3";
        }
        protected void b4_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "4";
        }
        protected void b5_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "5";
        }
        protected void b6_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "6";
        }
        protected void b7_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "7";
        }
        protected void b8_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "8";
        }
        protected void b9_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "9";
        }
        protected void b0_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + "0";
        }
        protected void bcom_Click(object sender, EventArgs e)
        {
            lresultado.Text = lresultado.Text + ",";
        }
        protected void bsuma_Click(object sender, EventArgs e)
        {
            rsuma.Checked = true;
            rresta.Checked = false;
            rmulti.Checked = false;
            rdivision.Checked = false;
            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            Operaciones.valor1 = valor1;
            lresultado.Text = string.Empty;
        }
        protected void bresta_Click(object sender, EventArgs e)
        {
            rresta.Checked = true;
            rsuma.Checked = false;
            rmulti.Checked = false;
            rdivision.Checked = false;
            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            Operaciones.valor1 = valor1;
            lresultado.Text = string.Empty;
        }
        protected void bmulti_Click(object sender, EventArgs e)
        {
            rmulti.Checked = true;
            rresta.Checked = false;
            rsuma.Checked = false;
            rdivision.Checked = false;
            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            Operaciones.valor1 = valor1;
            lresultado.Text = string.Empty;
        }
        protected void bdiv_Click(object sender, EventArgs e)
        {
            rdivision.Checked = true;
            rresta.Checked = false;
            rmulti.Checked = false;
            rsuma.Checked = false;
            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            Operaciones.valor1 = valor1;
            lresultado.Text = string.Empty;
        }
        protected void braiz_Click(object sender, EventArgs e)
        {
            RaizCu.Checked = true;
            rsuma.Checked = false;
            rresta.Checked = false;
            rmulti.Checked = false;
            rdivision.Checked = false;
            Pot2.Checked = false;
            Pot3.Checked = false;
            Facto.Checked = false;
            Fibon.Checked = false;

            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            Operaciones.valor1 = valor1;

            lresultado.Text = string.Empty;
        }
        protected void bpot2_Click(object sender, EventArgs e)
        {
            RaizCu.Checked = false;
            rsuma.Checked = false;
            rresta.Checked = false;
            rmulti.Checked = false;
            rdivision.Checked = false;
            Pot2.Checked = true;
            Pot3.Checked = false;
            Facto.Checked = false;
            Fibon.Checked = false;

            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            Operaciones.valor1 = valor1;

            lresultado.Text = string.Empty;
        }
        protected void bpot3_Click(object sender, EventArgs e)
        {
            RaizCu.Checked = false;
            rsuma.Checked = false;
            rresta.Checked = false;
            rmulti.Checked = false;
            rdivision.Checked = false;
            Pot2.Checked = false;
            Pot3.Checked = true;
            Facto.Checked = false;
            Fibon.Checked = false;

            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            Operaciones.valor1 = valor1;

            lresultado.Text = string.Empty;
        }

        protected void bfact_Click(object sender, EventArgs e)
        {
            Facto.Checked = true;
            rsuma.Checked = false;
            rresta.Checked = false;
            rmulti.Checked = false;
            rdivision.Checked = false;
            Pot2.Checked = false;
            Pot3.Checked = false;
            RaizCu.Checked = false;
            Fibon.Checked = false;
            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            Operaciones.valor1 = valor1;

            lresultado.Text = string.Empty;
        }
        protected void bfibon_Click(object sender, EventArgs e)
        {
            Fibon.Checked = true;
            rsuma.Checked = false;
            rresta.Checked = false;
            rmulti.Checked = false;
            rdivision.Checked = false;
            Pot2.Checked = false;
            Pot3.Checked = false;
            RaizCu.Checked = false;
            Facto.Checked = false;

            float valor1;
            float.TryParse(lresultado.Text, out valor1);
            Operaciones.valor1 = valor1;

            lresultado.Text = string.Empty;
        }

        protected void bclear_Click(object sender, EventArgs e)
        {
            Tvalor1.Text = "";
            Tvalor2.Text = "";
            lresultado.Text = "";
            Operaciones.valor1 = 0;
            Operaciones.valor2 = 0;
            Operaciones.sumar = false;
            Operaciones.restar = false;
            Operaciones.multiplicar = false;
            Operaciones.dividir = false;
            Operaciones.factorial = false;
            Operaciones.fibonacci = false;
            rsuma.Checked = false;
            rresta.Checked = false;
            rdivision.Checked =false;
            rmulti.Checked  = false;
            Pot2.Checked = false;
            Pot3.Checked = false;
            Fibon.Checked = false;
            Pot2.Checked = false;
            Pot3.Checked = false;
            RaizCu.Checked = false;
            Facto.Checked = false;
        }
        protected void bequal_Click(object sender, EventArgs e)
        {
            float valor2;
            float.TryParse(lresultado.Text, out valor2);
            Operaciones.valor2 = valor2;
            Bcalcular_Click(sender, e);
        }
    }
}