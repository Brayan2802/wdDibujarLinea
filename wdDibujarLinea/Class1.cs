using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wdDibujarLinea
{
    class clsLinea
    {
        private int Xi;
        private int Yi;
        private int Xf;
        private int Yf;

        private static int contar = 0;

        public clsLinea()
        {
            Xi = 0;
            Yi = 0;
            Xf = 0;
            Yf = 0;
        }

        public clsLinea(int Xi, int Yi, int Xf, int Yf)
        {
            this.Xi = Xi;
            this.Yi = Yi;
            this.Xf = Xf;
            this.Yf = Yf;
        }
        public clsLinea(double Xi, double Yi, double Xf, double Yf)
        {
            this.Xi = (int)Xi;
            this.Yi = (int)Yi;
            this.Xf = (int)Xf;
            this.Yf = (int)Yf;
        }
        public int obtenXi()
        {
            return Xi;
        }
        public int obtenYi()
        {
            return Yi;
        }
        public int obtenXf()
        {
            return Xf;
        }
        public int obtenYf()
        {
            return Yf;
        }
        public void cambiarXi(int Xi)
        {
            this.Xi = Xi;
        }
        public void cambiarYi(int Yi)
        {
            this.Yi = Yi;
        }
        public void cambiarXf(int Xf)
        {
            this.Xf = Xf;
        }
        public void cambiarYf(int Yf)
        {
            this.Yf = Yf;
        }
        public static int obtencuenta()
        {
            contar += 1;
            return contar;
        }
    }
}
