using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalculator_repaso_02_11
{
    public class Operaciones
    {
        public static float valor1 { get; set; }
        public static float valor2 { get; set; }

        public static bool sumar = false;
        public static bool restar = false;
        public static bool multiplicar = false;
        public static bool dividir = false;
        public static bool factorial = false;
        public static bool fibonacci = false;
        public static bool raiz = false;
        public static bool exponente2 = false;
        public static bool exponente3 = false;

        protected void bclear_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            Operaciones.valor1 = 0;
            Operaciones.valor2 = 0;
            Operaciones.sumar = false;
            Operaciones.restar = false;
            Operaciones.multiplicar = false;
            Operaciones.dividir = false;
            Operaciones.fibonacci = false;
            Operaciones.factorial = false;
            Operaciones.raiz = false;
            Operaciones.exponente2 = false;
            Operaciones.exponente3 = false;
        }

            public static float metodo_sumar(float v1, float v2)
        {
            return v1 + v2;
        }
        public static float metodo_restar(float v1, float v2)
        {
            return v1 - v2;
        }
        public static float metodo_multiplicar(float v1, float v2)
        {
            return v1 * v2;
        }
        public static float metodo_dividir(float v1, float v2)
        {
            return v1 / v2;
        }
        
    }
}
