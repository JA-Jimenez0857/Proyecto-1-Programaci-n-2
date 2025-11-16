using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalculator_repaso_02_11
{
    public class ClsCheckbox
    {
        private float num1 { get; set; }
        private float num2 { get; set; }

        public ClsCheckbox(float n1, float n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public float Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public float Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public float sumar()
        {
            return num1 + num2;
        }
        public float restar()
        {
            return num1 - num2;
        }
        public float Multiplicar()
        {
            return num1 * num2;
        }
        public float Dividir()
        {
            return num1 / num2;
        }
    }
}