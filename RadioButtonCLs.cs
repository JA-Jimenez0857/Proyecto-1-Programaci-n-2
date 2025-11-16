using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace WebCalculator_repaso_02_11
{
    public class RadioButtonCLs
    {
        public float Sumar(float n1, float n2)
        {
            return n1 + n2;
        }
        public static float Restar(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float Multiplicar(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float Dividir(float n1, float n2)
        {
            return n1 / n2;
        }
    }


}